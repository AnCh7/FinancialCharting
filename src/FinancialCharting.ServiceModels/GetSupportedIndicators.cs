#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

using ServiceStack.ServiceHost;

#endregion

namespace FinancialCharting.ServiceModels
{
	[Route("/indicators", "GET")]
	public class GetSupportedIndicators : IReturn<GetSupportedIndicatorsResponse>
	{}

	[DataContract]
	public class GetSupportedIndicatorsResponse : BaseReponse
	{
		[DataMember(Name = "data")]
		public List<string> Data { get; set; }
	}
}
