#region Usings

using System;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Interfaces
{
	public interface IMarketData
	{
		DateTime Date { get; set; }

		long UnixTimeMs { get; }
	}
}
