namespace FinancialCharting.Library.Models.Common
{
	public class PagingOptions
	{
		public PagingOptions(int perPage, int pageNumber)
		{
			PerPage = perPage;
			PageNumber = pageNumber;
		}

		public int PerPage { get; private set; }

		public int PageNumber { get; private set; }
	}
}
