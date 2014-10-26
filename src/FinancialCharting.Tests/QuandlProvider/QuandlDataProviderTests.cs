#region Usings

using System.Linq;

using Autofac;

using FinancialCharting.Library.Configuration;
using FinancialCharting.Library.Models.Common;
using FinancialCharting.Library.ProjectExceptions;
using FinancialCharting.QuandlProvider.Interfaces;
using FinancialCharting.Service.Resolver;
using FinancialCharting.ServiceModels;

using NUnit.Framework;

#endregion

namespace FinancialCharting.Tests.QuandlProvider
{
	public class QuandlProviderTests
	{
		private readonly IQuandlDataProvider _dataProvider;

		public QuandlProviderTests()
		{
			_dataProvider = DependencyContainer.Instance.Resolve<IQuandlDataProvider>();
		}

		[Test]
		public void Get_FinancialDataSources()
		{
			// Arrange

			// Act
			var dataSource = _dataProvider.GetFinancialDataSources();

			// Assert
			Assert.True(dataSource.Success);
			Assert.True(dataSource.Data.Any());
		}

		[Test]
		public void Get_All_FinancialDataSources()
		{
			// Arrange

			// Act
			var dataSource = _dataProvider.GetAllFinancialDataSources(QuandlSettings.QuandlWebUrl);

			// Assert
			Assert.True(dataSource.Success);
			Assert.True(dataSource.Data.Any());
		}

		[Test]
		public void Get_All_FinancialDataSources_Fail_Empty_Url()
		{
			// Arrange

			// Act
			// Assert
			Assert.Throws<QuandlProviderException>(() => _dataProvider.GetAllFinancialDataSources(string.Empty));
		}

		[Test]
		public void Get_All_FinancialDataSources_Fail_WrongUrl()
		{
			// Arrange

			// Act
			var dataSource = _dataProvider.GetAllFinancialDataSources("https://www.quandl.com/resources/data-source");

			// Assert
			Assert.False(dataSource.Success);
			Assert.AreEqual("Can't load data sources list from web site", dataSource.ErrorMessage);
		}

		[Test]
		public void GetMarketData_Invalid_Ticker()
		{
			// Arrange
			var request = new GetMarketData();
			request.DataSource = "GOOG";
			request.Ticker = "AAPL";

			// Act
			var dataSource = _dataProvider.GetMarketData(request);

			// Assert
			Assert.False(dataSource.Success);
			Assert.AreEqual("Requested entity does not exist.", dataSource.ErrorMessage);
		}

		[Test]
		public void GetMarketData_Only_Required_Fields()
		{
			// Arrange
			var request = new GetMarketData();
			request.DataSource = "GOOG";
			request.Ticker = "NASDAQ_TSLA";

			// Act
			var dataSource = _dataProvider.GetMarketData(request);

			// Assert
			Assert.True(dataSource.Success);
			Assert.True(dataSource.Data.Any());
		}

		[Test]
		public void GetTickers()
		{
			// Arrange
			const string query = "GOOG";
			const bool isSearch = false;
			var paging = new PagingOptions(10, 1);

			// Act
			var dataSource = _dataProvider.GetTickers(query, isSearch, paging);

			// Assert
			Assert.True(dataSource.Success);
			Assert.True(dataSource.Data.Tickers.Any());
		}

		[Test]
		public void GetTickers_Search()
		{
			// Arrange
			const string query = "crude oil";
			const bool isSearch = true;
			var paging = new PagingOptions(10, 1);

			// Act
			var dataSource = _dataProvider.GetTickers(query, isSearch, paging);

			// Assert
			Assert.True(dataSource.Success);
			Assert.True(dataSource.Data.Tickers.Any());
		}
	}
}
