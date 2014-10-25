#region Usings

using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	/// NSE ["Date","Open","High","Low","Close","SharesTraded","Turnover"]
	[DataContract]
	public class NseData
	{
		[DataMember(Name = "Turnover")]
		public string Turnover { get; set; }
	}
}
