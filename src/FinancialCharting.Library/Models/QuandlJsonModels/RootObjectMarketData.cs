#region Usings

using System.Collections.Generic;

#endregion

namespace FinancialCharting.Library.Models.QuandlJsonModels
{
	public class RootObjectMarketData
	{
		public Errors errors { get; set; }
		public int id { get; set; }
		public string source_name { get; set; }
		public string source_code { get; set; }
		public string code { get; set; }
		public string name { get; set; }
		public string urlize_name { get; set; }
		public string display_url { get; set; }
		public string description { get; set; }
		public string updated_at { get; set; }
		public string frequency { get; set; }
		public string from_date { get; set; }
		public string to_date { get; set; }
		public List<string> column_names { get; set; }
		public bool @private { get; set; }
		public object type { get; set; }
		public bool premium { get; set; }
		public List<List<object>> data { get; set; }
	}
}
