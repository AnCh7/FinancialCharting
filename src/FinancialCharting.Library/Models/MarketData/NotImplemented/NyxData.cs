#region Usings

using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	/// NYX ["Date","Open","High","Low","Close","Number of Shares","Number of Trades","Turnover"]
	[DataContract]
	public class NyxData
	{
		[DataMember(Name = "TradesCount")]
		public string TradesCount { get; set; }

		[DataMember(Name = "Turnover")]
		public string Turnover { get; set; }
	}
}
