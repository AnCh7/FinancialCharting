#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models;

using ServiceStack.ServiceHost;

#endregion

namespace FinancialCharting.ServiceModels
{
	[Route("/financialDataSources", "GET")]
	public class GetFinancialDataSources : IReturn<GetFinancialDataSourcesResponse>
	{}

	[DataContract]
	public class GetFinancialDataSourcesResponse : BaseReponse
	{
		[DataMember(Name = "data")]
		public List<DataSource> Data { get; set; }
	}
}
