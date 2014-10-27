#region Usings

using System;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Interfaces
{
	public interface IMarketData
	{
		DateTime Datetime { get; set; }

		long UnixTimeMs { get; }
	}
}
