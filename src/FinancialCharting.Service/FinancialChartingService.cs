#region Usings

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using Autofac;

using FinancialCharting.Library.Enum;
using FinancialCharting.Library.Models;
using FinancialCharting.Library.Models.Common;
using FinancialCharting.Library.Models.Indicator;
using FinancialCharting.QuandlProvider.Interfaces;
using FinancialCharting.Service.Resolver;
using FinancialCharting.ServiceModels;
using FinancialCharting.TechnicalAnalysisLibrary;

using ServiceStack.ServiceInterface;
using ServiceStack.ServiceInterface.Cors;
using ServiceStack.ServiceInterface.ServiceModel;
using ServiceStack.Text;

#endregion

namespace FinancialCharting.Service
{
	[EnableCors]
	public sealed class FinancialChartingService : ServiceStack.ServiceInterface.Service
	{
		private readonly CachingManager _cachingManager;
		private readonly IQuandlDataProvider _dataProvider;
		private readonly TechnicalIndicatorsManager _technicalIndicatorsProvider;

		public FinancialChartingService()
		{
			_cachingManager = new CachingManager(Cache);
			_dataProvider = DependencyContainer.Instance.Resolve<IQuandlDataProvider>();
			_technicalIndicatorsProvider = DependencyContainer.Instance.Resolve<TechnicalIndicatorsManager>();
		}

		public object Get(GetFinancialDataSources request)
		{
			var response = new GetFinancialDataSourcesResponse();

			try
			{
				const string key = "FinacialDataSources";
				var cached = _cachingManager.GetFinancialDataSources(key);
				if (cached != null)
				{
					return cached;
				}

				OperationResult<List<DataSource>> result;
				if (Request.PathInfo.EndsWith("all"))
				{
					result = _dataProvider.GetAllFinancialDataSources();
				}
				else
				{
					result = _dataProvider.GetFinancialDataSources();
				}

				if (result.Success)
				{
					response.Success = true;
					response.Data = result.Data;
					_cachingManager.Save(key, response);
				}
				else
				{
					response.ResponseStatus = new ResponseStatus(string.Empty, result.ErrorMessage);
				}
			}
			catch (Exception ex)
			{
				var status = new ResponseStatus();
				status.Message = ex.Message;
				status.ErrorCode = ex.Source;
				status.StackTrace = ex.StackTrace;

				response.ResponseStatus = status;
			}

			return response;
		}

		public object Get(GetTickers request)
		{
			var response = new GetTickersResponse();

			try
			{
				if (string.IsNullOrEmpty(request.DataSource) && string.IsNullOrEmpty(request.Query))
				{
					throw new ServiceResponseException("Unknown request. Missing parameters.");
				}
				if (request.PerPage <= 0)
				{
					throw new ArgumentNullException("request", "Invalid [PerPage] field");
				}
				if (request.PageNumber < 0)
				{
					throw new ArgumentNullException("request", "Invalid [PageNumber] field");
				}

				var cached = _cachingManager.GetTickers(request.ToJson());
				if (cached != null)
				{
					return cached;
				}
				else
				{
					var result = !string.IsNullOrEmpty(request.Query) ?
						_dataProvider.GetTickers(request.Query, true, new PagingOptions(request.PerPage, request.PageNumber)) :
						_dataProvider.GetTickers(request.DataSource, false, new PagingOptions(request.PerPage, request.PageNumber));

					if (result != null)
					{
						if (result.Success)
						{
							response.Success = true;
							response.Data = result.Data;
							_cachingManager.Save(request.ToJson(), response);
						}
						else
						{
							response.ResponseStatus = new ResponseStatus(string.Empty, result.ErrorMessage);
						}
					}
					else
					{
						response.ResponseStatus = new ResponseStatus(string.Empty, "Result is empty");
					}
				}
			}
			catch (Exception ex)
			{
				var status = new ResponseStatus();
				status.Message = ex.Message;
				status.ErrorCode = ex.Source;
				status.StackTrace = ex.StackTrace;

				response.ResponseStatus = status;
			}

			return response;
		}

		public object Get(GetMarketData request)
		{
			var response = new GetMarketDataResponse();

			try
			{
				if (string.IsNullOrEmpty(request.DataSource))
				{
					throw new ArgumentNullException("request", "[DataSource] field is empty");
				}
				if (string.IsNullOrEmpty(request.Ticker))
				{
					throw new ArgumentNullException("request", "[Ticker] field is empty");
				}

				var cache = _cachingManager.GetMarketData(request.ToJson());
				if (cache != null)
				{
					return cache;
				}
				else
				{
					var result = _dataProvider.GetMarketData(request);
					if (result.Success)
					{
						response.Success = true;
						response.Data = result.Data;
						_cachingManager.Save(request.ToJson(), response);
						_cachingManager.SaveCurrentChart("CurrentChart", request);
					}
					else
					{
						response.ResponseStatus = new ResponseStatus(string.Empty, result.ErrorMessage);
					}
				}
			}
			catch (Exception ex)
			{
				var status = new ResponseStatus();
				status.Message = ex.Message;
				status.ErrorCode = ex.Source;
				status.StackTrace = ex.StackTrace;

				response.ResponseStatus = status;
			}

			return response;
		}

		public object Get(GetSupportedIndicators request)
		{
			var response = new GetSupportedIndicatorsResponse();

			try
			{
				var result = (from object x in Enum.GetValues(typeof (IndicatorType)) select x.ToString()).ToList();
				if (result.Any())
				{
					response.Success = true;
					response.Data = result;
				}
				else
				{
					response.ResponseStatus = new ResponseStatus(string.Empty, "Error");
				}
			}
			catch (Exception ex)
			{
				var status = new ResponseStatus();
				status.Message = ex.Message;
				status.ErrorCode = ex.Source;
				status.StackTrace = ex.StackTrace;

				response.ResponseStatus = status;
			}

			return response;
		}

		public object Get(CalculateTechnicalIndicator request)
		{
			var response = new CalculateTechnicalIndicatorResponse();

			try
			{
				if (request.Type == IndicatorType.NONE)
				{
					throw new ArgumentNullException("request", "[IndicatorType] field is empty");
				}
				if (request.Period1 < 0)
				{
					throw new ArgumentNullException("request", "[Period1] field is negative number");
				}

				var currentChart = _cachingManager.GetCurrentChart("CurrentChart");
				if (currentChart == null)
				{
					throw new DataException("No information about current chart was found");
				}
				else
				{
					var cache = _cachingManager.GetTechnicalIndicators(currentChart.ToJson() + request.ToJson());
					if (cache != null)
					{
						return cache;
					}
					else
					{
						var cachedMarketData = _cachingManager.GetMarketData(currentChart.ToJson());
						if (cachedMarketData == null)
						{
							throw new DataException("No market data for current chart was found");
						}
						else
						{
							var parameters = IndicatorParametersFactory.Create(request.Type, request.Period1, request.Period2, request.Period3);
							var result = _technicalIndicatorsProvider.CalculateIndicator(cachedMarketData.Data, parameters);
							if (result.Success)
							{
								response.Success = true;
								response.Data = result.Data;
								_cachingManager.Save(currentChart.ToJson() + request.ToJson(), response);
							}
							else
							{
								response.ResponseStatus = new ResponseStatus(string.Empty, result.ErrorMessage);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				var status = new ResponseStatus();
				status.Message = ex.Message;
				status.ErrorCode = ex.Source;
				status.StackTrace = ex.StackTrace;

				response.ResponseStatus = status;
			}

			return response;
		}
	}
}
