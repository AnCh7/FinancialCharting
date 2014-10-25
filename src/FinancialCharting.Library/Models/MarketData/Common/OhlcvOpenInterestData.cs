#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	/// ASX ["Date","Open","High","Low","Settle","Volume","Open Interest (OI)"]
	/// EUREX ["Date","Open","High","Low","Settle","Volume","Prev. Day Open Interest"]
	/// LIFFE ["Date","Open","High","Low","Settle","Volume","Interest"]
	/// MGEX ["Date","Open","High","Low","Last","Volume","Prev. Day Open Interest"]
	/// PXDATA ["Date","Open","High","Low","Settle","Volume","Open Interest (OI)"]
	[DataContract]
	public class OhlcvOpenInterestData : OhlcvData
	{
		public OhlcvOpenInterestData(List<object> data) : base(data)
		{
			OpenInterest = Convert.ToDouble(data[6]);
		}

		[DataMember(Name = "openInterest", Order = 7)]
		public double OpenInterest { get; set; }
	}
}
