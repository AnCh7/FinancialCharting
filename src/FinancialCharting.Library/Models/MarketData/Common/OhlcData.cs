#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Interfaces;

using ServiceStack.Text;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	/// PHILSE ["Date","Open","High","Low","Close"]
	[DataContract]
	public class OhlcData : IOhlc
	{
		public OhlcData(List<object> data)
		{
			Date = Convert.ToDateTime(data[0]);
			Open = Convert.ToDouble(data[1]);
			High = Convert.ToDouble(data[2]);
			Low = Convert.ToDouble(data[3]);
			Close = Convert.ToDouble(data[4]);
		}

		[DataMember(Name = "date", Order = 0)]
		public DateTime Date { get; set; }

		[DataMember(Name = "date_unix")]
		public long UnixTimeMs
		{
			get { return Date.ToUnixTimeMs(); }
		}

		[DataMember(Name = "open", Order = 1)]
		public double Open { get; set; }

		[DataMember(Name = "high", Order = 2)]
		public double High { get; set; }

		[DataMember(Name = "low", Order = 3)]
		public double Low { get; set; }

		[DataMember(Name = "close", Order = 4)]
		public double Close { get; set; }
	}
}
