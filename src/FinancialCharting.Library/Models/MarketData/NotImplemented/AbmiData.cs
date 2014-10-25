#region Usings

using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	/// ABMI ["Date","Government Bonds","Corporate Bonds","Total"]
	[DataContract]
	public class AbmiData
	{
		[DataMember(Name = "GovernmentBonds")]
		public string GovernmentBonds { get; set; }

		[DataMember(Name = "CorporateBonds")]
		public string CorporateBonds { get; set; }

		[DataMember(Name = "Total")]
		public string Total { get; set; }
	}
}
