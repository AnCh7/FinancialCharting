#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models
{
	[DataContract]
	public class Ticker
	{
		[DataMember(Name = "source_code")]
		public string SourceCode { get; set; }

		[DataMember(Name = "code")]
		public string Code { get; set; }

		[DataMember(Name = "name")]
		public string Name { get; set; }

		[DataMember(Name = "description")]
		public string Description { get; set; }

		[DataMember(Name = "updated_at")]
		public string UpdatedAt { get; set; }

		[DataMember(Name = "timeframe")]
		public string TimeFrame { get; set; }

		[DataMember(Name = "from_date")]
		public string FromDate { get; set; }

		[DataMember(Name = "to_date")]
		public string ToDate { get; set; }

		[DataMember(Name = "columns")]
		public List<string> Columns { get; set; }
	}
}
