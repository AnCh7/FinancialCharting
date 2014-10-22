#region Usings

using System.Collections.Generic;

using FinancialCharting.Library.Models;
using FinancialCharting.Library.Models.MarketData.Interfaces;
using FinancialCharting.Library.Models.QuandlJsonModels;

#endregion

namespace FinancialCharting.Library.Quandl.Interfaces
{
	public interface IQuandlMapper
	{
		DataSet ToDataSet(RootObjectDataSet jsonModel);

		Ticker ToTicker(Doc jsonModel);

		IMarketData ToMarketData(string dataSourceName, List<object> data);
	}
}
