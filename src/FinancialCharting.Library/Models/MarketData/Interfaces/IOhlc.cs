namespace FinancialCharting.Library.Models.MarketData.Interfaces
{
	public interface IOhlc : IMarketData
	{
		double Open { get; set; }

		double High { get; set; }

		double Low { get; set; }

		double Close { get; set; }
	}
}
