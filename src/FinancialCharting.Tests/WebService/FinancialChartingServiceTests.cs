#region Usings

using System;
using System.Linq;

using FinancialCharting.Library.Enum;
using FinancialCharting.Service;
using FinancialCharting.ServiceModels;

using NUnit.Framework;

using ServiceStack.ServiceClient.Web;

#endregion

namespace FinancialCharting.Tests.WebService
{
	internal class FinancialChartingServiceTests
	{
		private readonly string _webServiceUrl;

		public FinancialChartingServiceTests()
		{
			_webServiceUrl = @"http://localhost:1476/";
		}

		[Test]
		public void GetMarketData_All_Fields()
		{
			// Arrange
			var client = new JsonServiceClient(_webServiceUrl);

			var request = new GetMarketData();
			request.DataSource = "GOOG";
			request.Ticker = "NASDAQ_TSLA";
			request.From = new DateTime(2000, 01, 01, 00, 00, 00);
			request.To = new DateTime(2014, 01, 01, 00, 00, 00);
			request.RowsNumber = 300;
			request.Timeframe = TimeframeType.DAILY;
			request.Transformation = TransformationType.RDIFF;
			request.SortOrder = SortOrderType.DESC;
			request.ExcludeHeaders = false;
			request.SpecificColumnNumber = null;

			// Act
			var response = client.Get(request);
			client.Dispose();

			// Assert
			Assert.True(response.Data.Any());
		}
	}
}
