#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Models;

using ServiceStack.ServiceHost;

#endregion

namespace FinancialCharting.ServiceModels
{
	[Route("/allFinancialDataSources", "GET")]
	public class LoadAllFinancialDataSources : IReturn<LoadAllFinancialDataSourcesResponse>
	{}

	[DataContract]
	public class LoadAllFinancialDataSourcesResponse : BaseReponse
	{
		[DataMember(Name = "data")]
		public List<DataSource> Data { get; set; }
	}
}
