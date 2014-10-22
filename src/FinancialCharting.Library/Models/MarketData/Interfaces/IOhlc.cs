#region Usings

using System;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Interfaces
{
	public interface IOhlc
	{
		DateTime Date { get; set; }

		long UnixTimeMs { get; }

		double Open { get; set; }

		double High { get; set; }

		double Low { get; set; }

		double Close { get; set; }
	}
}
