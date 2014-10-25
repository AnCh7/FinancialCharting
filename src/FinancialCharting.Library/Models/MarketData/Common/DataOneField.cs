#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Interfaces;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	/// BCHAIN ["Date","Value"]
	/// EUREKA ["Date","Returns"]
	/// ML ["Date","Value"]
	/// NIKKEI ["Date","Close"]
	/// RENCAP ["Date","Value"]
	/// WFE ["Year","Million USD"]
	/// WGC ["Date","Value"]
	/// WREN ":["Date","Value"]
	/// THAISE ["Year","Value"]
	/// WSJ ["Date","Value"]
	[DataContract]
	public class DataOneField : DateComponent, IMarketData
	{
		public DataOneField(List<object> data) : base(data)
		{
			Value = Convert.ToDouble(data[1]);
		}

		[DataMember(Name = "value", Order = 2)]
		public double Value { get; set; }
	}
}
