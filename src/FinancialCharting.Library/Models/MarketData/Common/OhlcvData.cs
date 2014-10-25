#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	/// GOOG ["Date","Open","High","Low","Close","Volume"]
	[DataContract]
	public class OhlcvData : OhlcData
	{
		public OhlcvData(List<object> data) : base(data)
		{
			Volume = Convert.ToDouble(data[5]);
		}

		[DataMember(Name = "volume", Order = 6)]
		public double Volume { get; set; }
	}
}
