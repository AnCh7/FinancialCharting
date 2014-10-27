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
	public class DateComponent : IMarketData
	{
		public DateComponent(List<object> data)
		{
			Datetime = Convert.ToDateTime(data[0]);
			Date = data[0].ToString();
		}

		public DateTime Datetime { get; set; }

		[DataMember(Name = "date", Order = 0)]
		public string Date { get; set; }
		
		[DataMember(Name = "date_unix", Order = 1)]
		public long UnixTimeMs
		{
			get { return Datetime.ToUnixTimeMs(); }
		}
	}
}
