#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Interfaces;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	/// PHILSE ["Date","Open","High","Low","Close"]
	[DataContract]
	public class OhlcData : DateComponent, IOhlc, IMarketData
	{
		public OhlcData(List<object> data) : base(data)
		{
			Open = Convert.ToDouble(data[1]);
			High = Convert.ToDouble(data[2]);
			Low = Convert.ToDouble(data[3]);
			Close = Convert.ToDouble(data[4]);
		}

		[DataMember(Name = "open", Order = 2)]
		public double Open { get; set; }

		[DataMember(Name = "high", Order = 3)]
		public double High { get; set; }

		[DataMember(Name = "low", Order = 4)]
		public double Low { get; set; }

		[DataMember(Name = "close", Order = 5)]
		public double Close { get; set; }
	}
}
