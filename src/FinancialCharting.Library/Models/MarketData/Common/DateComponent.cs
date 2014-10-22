#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Interfaces;

using ServiceStack.Text;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Common
{
	[DataContract]
	public class DateComponent
	{
		public DateComponent(List<object> data)
		{
			Date = Convert.ToDateTime(data[0]);
		}

		[DataMember(Name = "date", Order = 0)]
		public DateTime Date { get; set; }

		[DataMember(Name = "date_unix")]
		public long UnixTimeMs
		{
			get { return Date.ToUnixTimeMs(); }
		}
	}
}
