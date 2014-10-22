#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Common;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Custom
{
	/// SGX ["Date","Open","High","Low","Close","Settle","Volume","Prev. Day Open Interest"]
	[DataContract]
	public class SgxData : OhlcvOpenInterestData
	{
		public SgxData(List<object> data) : base(data)
		{
			Settle = Convert.ToDouble(data[5]);
		}

		[DataMember(Name = "settle", Order = 5)]
		public double Settle { get; set; }

		[DataMember(Name = "volume", Order = 6)]
		public new double Volume { get; set; }

		[DataMember(Name = "openInterest", Order = 7)]
		public new double OpenInterest { get; set; }
	}
}
