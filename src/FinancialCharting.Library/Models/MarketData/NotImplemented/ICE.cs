#region Usings

using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.NotImplemented
{
	// ICE ["Date","Open","High","Low","Settle","Change","Wave","Volume","Open Interest","EFP Volume","EFS Volume","Block Volume"]
	[DataContract]
	public class ICE
	{
		[DataMember(Name = "Change")]
		public string Change { get; set; }

		[DataMember(Name = "Wave")]
		public string Wave { get; set; }

		[DataMember(Name = "Volume")]
		public string Volume { get; set; }

		[DataMember(Name = "OpenInterest")]
		public string OpenInterest { get; set; }

		[DataMember(Name = "EFPVolume")]
		public string EFPVolume { get; set; }

		[DataMember(Name = "EFSVolume")]
		public string EFSVolume { get; set; }

		[DataMember(Name = "BlockVolume")]
		public string BlockVolume { get; set; }
	}
}
