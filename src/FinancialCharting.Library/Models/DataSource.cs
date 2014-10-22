#region Usings

using System.Runtime.Serialization;

#endregion

namespace FinancialCharting.Library.Models
{
	[DataContract]
	public class DataSource
	{
		[DataMember(Name = "code")]
		public string Code { get; set; }

		[DataMember(Name = "datasets_count")]
		public int Count { get; set; }

		[DataMember(Name = "description")]
		public string Description { get; set; }

		[DataMember(Name = "name")]
		public string Name { get; set; }
	}
}
