#region Usings

using System;
using System.Collections.Generic;

using FinancialCharting.Library.Models;
using FinancialCharting.Library.Models.MarketData.Common;
using FinancialCharting.Library.Models.MarketData.Custom;
using FinancialCharting.Library.Models.MarketData.Interfaces;
using FinancialCharting.Library.Models.QuandlJsonModels;
using FinancialCharting.Library.ProjectExceptions;
using FinancialCharting.Library.Quandl.Interfaces;

#endregion

namespace FinancialCharting.Library.Quandl
{
	public class QuandlMapper : IQuandlMapper
	{
		public DataSet ToDataSet(RootObjectDataSet jsonModel)
		{
			var dataSet = new DataSet();

			dataSet.TotalCount = jsonModel.total_count;
			dataSet.CurrentPage = jsonModel.current_page;
			dataSet.PerPage = jsonModel.per_page;
			dataSet.Start = jsonModel.start;
			dataSet.Tickers = new List<Ticker>();

			foreach (var doc in jsonModel.docs)
			{
				var ticker = ToTicker(doc);
				dataSet.Tickers.Add(ticker);
			}

			return dataSet;
		}

		public Ticker ToTicker(Doc jsonModel)
		{
			var ticker = new Ticker();

			ticker.SourceCode = jsonModel.source_code;
			ticker.Code = jsonModel.code;
			ticker.Name = jsonModel.name;
			ticker.Description = jsonModel.description;
			ticker.UpdatedAt = jsonModel.updated_at;
			ticker.TimeFrame = jsonModel.frequency;
			ticker.FromDate = jsonModel.from_date;
			ticker.ToDate = jsonModel.to_date;
			ticker.Columns = jsonModel.column_names;

			return ticker;
		}

		public IMarketData ToMarketData(string dataSourceName, List<object> data)
		{
			try
			{
				switch (dataSourceName)
				{
					case "ASX":
						if (data.Count == 2)
						{
							return new SimpleDataOneField(data);
						}
						if (data.Count == 7)
						{
							return new OhlcvOpenInterestData(data);
						}
						throw new NotSupportedException();

					case "BCHAIN":
					case "DMDRN":
					case "EUREKA":
					case "ML":
					case "NIKKEI":
					case "RENCAP":
					case "SANDP":
					case "THAISE":
					case "WFE":
					case "WGC":
					case "WREN":
					case "WSJ":
					case "SEC":
						if (data.Count == 2)
						{
							return new SimpleDataOneField(data);
						}
						throw new NotSupportedException();

					case "BUDAPESTSE":
						if (data.Count == 2)
						{
							return new SimpleDataOneField(data);
						}
						if (data.Count == 5)
						{
							return new BudapestseData(data);
						}
						throw new NotSupportedException();

					case "EUREX":
					case "LIFFE":
					case "MGEX":
					case "PXDATA":
						if (data.Count == 7)
						{
							return new OhlcvOpenInterestData(data);
						}
						throw new NotSupportedException();

					case "GOOG":
						if (data.Count == 6)
						{
							return new OhlcvData(data);
						}
						throw new NotSupportedException();

					case "PHILSE":
						if (data.Count == 5)
						{
							return new OhlcData(data);
						}
						throw new NotSupportedException();

					case "QUANDL":
					case "PSYCH":
						if (data.Count == 3)
						{
							return new SimpleDataTwoFields(data);
						}
						if (data.Count == 4)
						{
							return new SimpleDataThreeFields(data);
						}
						throw new NotSupportedException();

					case "FINRA":
						if (data.Count == 4)
						{
							return new SimpleDataThreeFields(data);
						}
						throw new NotSupportedException();

					case "SGX":
						if (data.Count == 8)
						{
							return new SgxData(data);
						}
						throw new NotSupportedException();

					case "YAHOO":
						if (data.Count == 6)
						{
							return new OhlcvData(data);
						}
						if (data.Count == 7)
						{
							return new YahooData(data);
						}
						throw new NotSupportedException();

					default:
						if (data.Count == 2)
						{
							return new SimpleDataOneField(data);
						}
						if (data.Count == 3)
						{
							return new SimpleDataTwoFields(data);
						}
						if (data.Count == 4)
						{
							return new SimpleDataThreeFields(data);
						}
						if (data.Count == 5)
						{
							return new OhlcData(data);
						}
						if (data.Count == 6)
						{
							return new OhlcvData(data);
						}
						throw new NotSupportedException();
				}
			}
			catch (NotSupportedException)
			{
				throw;
			}
			catch (Exception ex)
			{
				throw new ParsingException(ex);
			}
		}
	}
}
