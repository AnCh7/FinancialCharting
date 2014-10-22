#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	/// BCHAIN ["Date","Value"]
	/// EUREKA ["Date","Returns"]
	/// ML ["Date","Value"]
	/// NIKKEI ["Date","Close"]
	/// SANDP ["Month","Index"]
	/// RENCAP ["Date","Value"]
	/// WFE ["Year","Million USD"]
	/// WGC ["Date","Value"]
	/// WREN ":["Date","Value"]
	/// THAISE ["Year","Value"]
	/// WSJ ["Date","Value"]
	[DataContract]
	public class SimpleDataOneField : DateComponent
	{
		public SimpleDataOneField(List<object> data) : base(data)
		{
			Value = Convert.ToDouble(data[1]);
		}

		[DataMember(Name = "value", Order = 1)]
		public double Value { get; set; }
	}
}
