#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using FinancialCharting.Library.Enum;
using FinancialCharting.Library.Models.MarketData.Interfaces;

using ServiceStack.ServiceHost;

#endregion

namespace FinancialCharting.ServiceModels
{
	[Route("/marketdata", "GET")]
	[Route("/marketdata/{DataSource}/{Ticker}", "GET")]
	public class GetMarketData : IReturn<GetMarketDataResponse>
	{
		[ApiMember(Name = "DataSource", ParameterType = "path", DataType = "string", IsRequired = true)]
		public string DataSource { get; set; }

		[ApiMember(Name = "Ticker", ParameterType = "path", DataType = "string", IsRequired = true)]
		public string Ticker { get; set; }

		[ApiMember(Name = "From", ParameterType = "query", DataType = "dateTime", IsRequired = false)]
		public DateTime? From { get; set; }

		[ApiMember(Name = "To", ParameterType = "query", DataType = "dateTime", IsRequired = false)]
		public DateTime? To { get; set; }

		[ApiMember(Name = "RowsNumber", ParameterType = "query", DataType = "int", IsRequired = false)]
		public int? RowsNumber { get; set; }

		[ApiMember(Name = "Timeframe", ParameterType = "query", DataType = "complex", IsRequired = false)]
		public TimeframeType? Timeframe { get; set; }

		[ApiMember(Name = "Transformation", ParameterType = "query", DataType = "complex", IsRequired = false)]
		public TransformationType? Transformation { get; set; }

		[ApiMember(Name = "SortOrder", ParameterType = "query", DataType = "complex", IsRequired = false)]
		public SortOrderType? SortOrder { get; set; }

		[ApiMember(Name = "ExcludeHeaders", ParameterType = "query", DataType = "boolean", IsRequired = false)]
		public bool? ExcludeHeaders { get; set; }

		[ApiMember(Name = "SpecificColumnNumber", ParameterType = "query", DataType = "int", IsRequired = false)]
		public int? SpecificColumnNumber { get; set; }
	}

	[DataContract]
	public class GetMarketDataResponse : BaseReponse
	{
		[DataMember(Name = "data")]
		public List<IMarketData> Data { get; set; }
	}
}
