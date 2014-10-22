#region Usings

using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Enum;
using FinancialCharting.Library.Models.Indicator;

using ServiceStack.ServiceHost;

#endregion

namespace FinancialCharting.ServiceModels
{
	[Route("/indicator/{Type}/{Period1}", "GET")]
	public class CalculateTechnicalIndicator : IReturn<CalculateTechnicalIndicatorResponse>
	{
		[ApiMember(Name = "Type", ParameterType = "path", DataType = "complex", IsRequired = true)]
		public IndicatorType Type { get; set; }

		[ApiMember(Name = "Period1", ParameterType = "path", DataType = "string", IsRequired = true)]
		public int Period1 { get; set; }

		[ApiMember(Name = "Period2", ParameterType = "query", DataType = "string", IsRequired = false)]
		public int? Period2 { get; set; }

		[ApiMember(Name = "Period3", ParameterType = "query", DataType = "string", IsRequired = false)]
		public int? Period3 { get; set; }
	}

	[DataContract]
	public class CalculateTechnicalIndicatorResponse : BaseReponse
	{
		[DataMember(Name = "data")]
		public List<Indicator> Data { get; set; }
	}
}
