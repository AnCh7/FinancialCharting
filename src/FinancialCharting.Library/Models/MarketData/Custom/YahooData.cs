#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models.MarketData.Common;

#endregion

namespace FinancialCharting.Library.Models.MarketData.Custom
{
	/// YAHOO ["Date","Open","High","Low","Close","Volume","Adjusted Close"]
	[DataContract]
	public class YahooData : OhlcvData
	{
		public YahooData(List<object> data) : base(data)
		{
			AdjustedClose = Convert.ToDouble(data[6]);
		}

		[DataMember(Name = "adjustedClose", Order = 7)]
		public double AdjustedClose { get; set; }
	}
}
