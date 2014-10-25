#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	/// PSYCH ["Date","Bullish","Bearish"]
	[DataContract]
	public class DataTwoFields : DataOneField
	{
		public DataTwoFields(List<object> data)
			: base(data)
		{
			Value2 = Convert.ToDouble(data[2]);
		}

		[DataMember(Name = "value", Order = 3)]
		public double Value2 { get; set; }
	}
}
