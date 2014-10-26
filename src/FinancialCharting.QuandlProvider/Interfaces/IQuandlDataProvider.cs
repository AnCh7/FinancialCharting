#region Usings

using System.Collections.Generic;

using FinancialCharting.Library.Models;
using FinancialCharting.Library.Models.Common;
using FinancialCharting.Library.Models.MarketData.Interfaces;
using FinancialCharting.ServiceModels;

#endregion

namespace FinancialCharting.QuandlProvider.Interfaces
{
	public interface IQuandlDataProvider
	{
		OperationResult<List<DataSource>> GetFinancialDataSources();

		OperationResult<List<DataSource>> GetAllFinancialDataSources(string url);

		OperationResult<DataSet> GetTickers(string query, bool isSearch, PagingOptions paging);

		OperationResult<List<IMarketData>> GetMarketData(GetMarketData request);
	}
}
