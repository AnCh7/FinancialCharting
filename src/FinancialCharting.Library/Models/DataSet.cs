#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models
{
	[DataContract]
	public class DataSet
	{
		[DataMember(Name = "total_count")]
		public int TotalCount { get; set; }

		[DataMember(Name = "current_page")]
		public int CurrentPage { get; set; }

		[DataMember(Name = "per_page")]
		public int PerPage { get; set; }

		[DataMember(Name = "start")]
		public int Start { get; set; }

		[DataMember(Name = "tickers")]
		public List<Ticker> Tickers { get; set; }
	}
}
