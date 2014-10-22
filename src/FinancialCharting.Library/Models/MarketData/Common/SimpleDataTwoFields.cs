#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	/// PSYCH ["Date","Bullish","Bearish"]
	[DataContract]
	public class SimpleDataTwoFields : SimpleDataOneField
	{
		public SimpleDataTwoFields(List<object> data)
			: base(data)
		{
			Value2 = Convert.ToDouble(data[2]);
		}

		[DataMember(Name = "value", Order = 2)]
		public double Value2 { get; set; }
	}
}
