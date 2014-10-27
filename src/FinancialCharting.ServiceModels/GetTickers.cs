#region Usings

using System.Runtime.Serialization;

using FinancialCharting.Library.Models;

using ServiceStack.ServiceHost;

#endregion

namespace FinancialCharting.ServiceModels
{
	[Route("/tickers", "GET")]
	[Route("/tickers/{PerPage}/{PageNumber}", "GET")]
	public class GetTickers : IReturn<GetTickersResponse>
	{
		[ApiMember(Name = "PerPage", ParameterType = "query", DataType = "int", IsRequired = true)]
		public int PerPage { get; set; }

		[ApiMember(Name = "PageNumber", ParameterType = "query", DataType = "int", IsRequired = true)]
		public int PageNumber { get; set; }

		[ApiMember(Name = "Query", ParameterType = "query", DataType = "string", IsRequired = false)]
		public string Query { get; set; }

		[ApiMember(Name = "DataSource", ParameterType = "query", DataType = "string", IsRequired = false)]
		public string DataSource { get; set; }
	}

	[DataContract]
	public class GetTickersResponse : BaseReponse
	{
		[DataMember(Name = "data")]
		public DataSet Data { get; set; }
	}
}
