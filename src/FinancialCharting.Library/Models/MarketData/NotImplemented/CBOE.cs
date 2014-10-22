#region Usings

using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	// CBOE ["Trade Date","Open","High","Low","Close","Settle","Change","Total Volume","EFP","Prev. Day Open Interest"]
	[DataContract]
	public class CBOE
	{
		[DataMember(Name = "Settle")]
		public string Settle { get; set; }

		[DataMember(Name = "Change")]
		public string Change { get; set; }

		[DataMember(Name = "TotalVolume")]
		public string TotalVolume { get; set; }

		[DataMember(Name = "EFP")]
		public string EFP { get; set; }

		[DataMember(Name = "PrevDayOpenInterest")]
		public string PrevDayOpenInterest { get; set; }
	}
}
