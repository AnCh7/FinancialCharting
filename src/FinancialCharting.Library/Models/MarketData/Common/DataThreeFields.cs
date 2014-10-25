#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	/// QUANDL ["Date","Rate","High","Low"]
	/// PSYCH ["Date","Bullish","Bearish","Ratio"]
	[DataContract]
	public class DataThreeFields : DataTwoFields
	{
		public DataThreeFields(List<object> data) : base(data)
		{
			Value3 = Convert.ToDouble(data[3]);
		}

		[DataMember(Name = "value3", Order = 4)]
		public double Value3 { get; set; }
	}
}
