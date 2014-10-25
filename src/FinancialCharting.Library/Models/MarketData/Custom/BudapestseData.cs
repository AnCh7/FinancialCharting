#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Common;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Custom
{
	/// BUDAPESTSE ["Date","Open","Close","Max","Min"]
	[DataContract]
	public class BudapestseData : OhlcData
	{
		public BudapestseData(List<object> data) : base(data)
		{
			Open = Convert.ToDouble(data[1]);
			Close = Convert.ToDouble(data[2]);
			High = Convert.ToDouble(data[3]);
			Low = Convert.ToDouble(data[4]);
		}

		[DataMember(Name = "open", Order = 2)]
		public new double Open { get; set; }

		[DataMember(Name = "high", Order = 3)]
		public new double High { get; set; }

		[DataMember(Name = "low", Order = 4)]
		public new double Low { get; set; }

		[DataMember(Name = "close", Order = 5)]
		public new double Close { get; set; }
	}
}
