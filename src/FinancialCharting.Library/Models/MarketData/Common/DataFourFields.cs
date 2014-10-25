#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	[DataContract]
	public class DataFourFields : DataThreeFields
	{
		public DataFourFields(List<object> data) : base(data)
		{
			Value4 = Convert.ToDouble(data[4]);
		}

		[DataMember(Name = "value4", Order = 5)]
		public double Value4 { get; set; }
	}
}
