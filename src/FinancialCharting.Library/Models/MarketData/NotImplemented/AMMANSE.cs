#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Common;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	// AMMANSE ["Date","Value Traded","# of Transactions","# of Shares","Index","% Change"]
	[DataContract]
	public class AMMANSE : DateComponent
	{
		public AMMANSE(List<object> data) : base(data)
		{}

		[DataMember(Name = "ValueTraded")]
		public string ValueTraded { get; set; }

		[DataMember(Name = "TransactionsCount")]
		public string TransactionsCount { get; set; }

		[DataMember(Name = "SharesCount")]
		public string SharesCount { get; set; }

		[DataMember(Name = "Index")]
		public string Index { get; set; }

		[DataMember(Name = "PercentChange")]
		public string PercentChange { get; set; }
	}
}
