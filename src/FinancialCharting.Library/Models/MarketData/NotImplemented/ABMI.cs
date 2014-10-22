#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Common;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	// ABMI ["Date","Government Bonds","Corporate Bonds","Total"]

	[DataContract]
	public class ABMI : DateComponent
	{
		public ABMI(List<object> data) : base(data)
		{}

		[DataMember(Name = "GovernmentBonds")]
		public string GovernmentBonds { get; set; }

		[DataMember(Name = "CorporateBonds")]
		public string CorporateBonds { get; set; }

		[DataMember(Name = "Total")]
		public string Total { get; set; }
	}
}
