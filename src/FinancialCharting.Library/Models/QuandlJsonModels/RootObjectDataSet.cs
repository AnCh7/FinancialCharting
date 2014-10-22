#region Usings

using System.Collections.Generic;

#endregion

namespace FinancialCharting.Library.Models.QuandlJsonModels
{
	public class RootObjectDataSet
	{
		public int total_count { get; set; }
		public int current_page { get; set; }
		public int per_page { get; set; }
		public List<Doc> docs { get; set; }
		public List<Source> sources { get; set; }
		public int start { get; set; }
		public Spellcheck spellcheck { get; set; }
		public List<List<object>> highlighting { get; set; }
	}
}
