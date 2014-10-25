#region Usings

using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	/// BITCOIN ["Date","Open","High"Ohlcvume (BTC)","Volume (Currency)","Weighted Price"]
	[DataContract]
	public class BitcoinData
	{
		[DataMember(Name = "VolumeInCurrency")]
		public double VolumeInCurrency { get; set; }

		[DataMember(Name = "WeightedPrice")]
		public double WeightedPrice { get; set; }
	}
}
