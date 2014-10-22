#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	[DataContract]
	public class SimpleDataFiveFields : SimpleDataFourFields
	{
		public SimpleDataFiveFields(List<object> data) : base(data)
		{
			Value3 = Convert.ToDouble(data[5]);
		}

		[DataMember(Name = "value5", Order = 5)]
		public double Value5 { get; set; }
	}
}
