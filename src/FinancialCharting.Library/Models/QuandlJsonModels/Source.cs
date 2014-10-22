namespace FinancialCharting.Library.Models.QuandlJsonModels
{
	public class Source
	{
		public int id { get; set; }
		public string code { get; set; }
		public int datasets_count { get; set; }
		public string description { get; set; }
		public string name { get; set; }
		public string host { get; set; }
		public bool premium { get; set; }
		public bool subscribed { get; set; }
	}
}
