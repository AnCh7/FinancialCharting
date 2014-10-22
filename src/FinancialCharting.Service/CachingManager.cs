#region Usings

using System;

using FinancialCharting.ServiceModels;

using ServiceStack.CacheAccess;

#endregion

namespace FinancialCharting.Service
{
	public class CachingManager
	{
		private readonly ICacheClient _client;

		public CachingManager(ICacheClient client)
		{
			_client = client;
		}

		public GetFinancialDataSourcesResponse GetAllFinancialDataSources(string key)
		{
			return _client.Get<GetFinancialDataSourcesResponse>(key);
		}

		public GetFinancialDataSourcesResponse GetFinancialDataSources(string key)
		{
			return _client.Get<GetFinancialDataSourcesResponse>(key);
		}

		public bool Save(string key, GetFinancialDataSourcesResponse response)
		{
			var cachedData = _client.Get<GetFinancialDataSourcesResponse>(key);
			if (cachedData == null)
			{
				var expireInTimespan = new TimeSpan(1, 0, 0, 0);
				_client.Add(key, response, expireInTimespan);
				return true;
			}
			else
			{
				return false;
			}
		}

		public GetTickersResponse GetTickers(string key)
		{
			return _client.Get<GetTickersResponse>(key);
		}

		public bool Save(string key, GetTickersResponse data)
		{
			var cachedData = _client.Get<GetTickersResponse>(key);
			if (cachedData == null)
			{
				var expireInTimespan = new TimeSpan(1, 0, 0, 0);
				_client.Add(key, data, expireInTimespan);
				return true;
			}
			else
			{
				return false;
			}
		}

		public GetMarketDataResponse GetMarketData(string key)
		{
			return _client.Get<GetMarketDataResponse>(key);
		}

		public bool Save(string key, GetMarketDataResponse data)
		{
			var cachedData = _client.Get<GetMarketDataResponse>(key);
			if (cachedData == null)
			{
				var expireInTimespan = new TimeSpan(0, 0, 5, 0);
				_client.Add(key, data, expireInTimespan);
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool SaveCurrentChart(string key, GetMarketData request)
		{
			return _client.Set(key, request);
		}

		public GetMarketData GetCurrentChart(string key)
		{
			return _client.Get<GetMarketData>(key);
		}

		public CalculateTechnicalIndicatorResponse GetTechnicalIndicators(string key)
		{
			return _client.Get<CalculateTechnicalIndicatorResponse>(key);
		}

		public bool Save(string key, CalculateTechnicalIndicatorResponse response)
		{
			var cachedData = _client.Get<CalculateTechnicalIndicatorResponse>(key);
			if (cachedData == null)
			{
				var expireInTimespan = new TimeSpan(0, 0, 5, 0);
				_client.Add(key, response, expireInTimespan);
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
