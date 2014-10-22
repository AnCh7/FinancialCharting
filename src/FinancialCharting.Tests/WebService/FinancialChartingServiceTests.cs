#region Usings

using System;

using NUnit.Framework;

#endregion

namespace FinancialCharting.Tests.WebService
{
	internal class FinancialChartingServiceTests
	{
		private readonly string _webServiceUrl;

		public FinancialChartingServiceTests()
		{
			_webServiceUrl = @"http://localhost:46847/";
		}

		//[Test]
		//public void MarketDataRequest_Test_Only_Necessarry_Fields()
		//{
		//	// Arrange
		//	var client = new JsonServiceClient(_webServiceUrl);

		//	var request = new MarketData();
		//	request.DataSource = "GOOG";
		//	request.Ticker = "NASDAQ_TSLA";
		//	request.From = new DateTime(2000, 01, 01, 00, 00, 00);
		//	request.To = new DateTime(2014, 01, 01, 00, 00, 00);
		//	request.Timeframe = TimeframeType.DAILY;

		//	// Act
		//	var response = client.Send(request);
		//	client.Dispose();

		//	// Assert
		//	Assert.True(response.Data.Any());
		//}

		//[Test]
		//public void MarketDataRequest_Test_Only_Necessarry_Fields()
		//{
		//	// Arrange
		//	var client = new JsonServiceClient(_webServiceUrl);

		//	var request = new MarketData();
		//	request.DataSource = "GOOG";
		//	request.Ticker = "NASDAQ_TSLA";
		//	request.From = new DateTime(2000, 01, 01, 00, 00, 00);
		//	request.To = new DateTime(2014, 01, 01, 00, 00, 00);
		//	request.Timeframe = TimeframeType.DAILY;

		//	// Act
		//	var response = client.Send(request);
		//	client.Dispose();

		//	// Assert
		//	Assert.True(response.Data.Any());
		//}

		//[Test]
		//public void MarketDataRequest_Test_All_Fields()
		//{
		//	// Arrange
		//	var client = new JsonServiceClient(_webServiceUrl);

		//	var request = new MarketData();
		//	request.DataSource = "GOOG";
		//	request.Ticker = "NASDAQ_TSLA";
		//	request.From = new DateTime(2000, 01, 01, 00, 00, 00);
		//	request.To = new DateTime(2014, 01, 01, 00, 00, 00);
		//	request.Timeframe = TimeframeType.DAILY;
		//	request.SortOrder = SortOrderType.asc;
		//	request.RowsNumber = 1000;
		//	request.Transformation = TransformationType.NONE;

		//	// Act
		//	var response = client.Send(request);
		//	client.Dispose();

		//	// Assert
		//	Assert.True(response.Data.Any());
		//}
	}
}
