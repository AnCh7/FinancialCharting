#region Usings

using System.Collections.Generic;

using FinancialCharting.Library.Models;
using FinancialCharting.Library.Models.Common;
using FinancialCharting.Library.Models.MarketData.Interfaces;

#endregion

namespace FinancialCharting.Library.Quandl.Interfaces
{
	public interface IQuandlProvider
	{
		OperationResult<List<DataSource>> GetFinancialDataSources();

		OperationResult<List<DataSource>> GetAllFinancialDataSources();

		OperationResult<DataSet> GetTickers(string query, bool isSearch, PagingOptions paging);

		OperationResult<List<IMarketData>> GetMarketData(QuandlMarketDataRequest request);
	}
}
