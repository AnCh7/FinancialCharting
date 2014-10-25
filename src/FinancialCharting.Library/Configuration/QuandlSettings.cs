#region Usings

using System.Collections.Generic;

using FinancialCharting.Library.Models;

#endregion

namespace FinancialCharting.Library.Configuration
{
	public class QuandlSettings
	{
		public const string QuandlUrl = "http://www.quandl.com/api/v1/datasets/";
		public const string QuandlSearchUrl = "http://www.quandl.com/api/v2/";

		public const string QuandlToken = "PxP16XZxY6xcFyiakHV6";

		public static readonly List<DataSource> DataSources = new List<DataSource>()
		{
			new DataSource {Name = "Google Finance", Count = 43000, Description = "US equities", Code = "GOOG"},
			new DataSource {Name = "Block Chain", Count = 30, Description = "Bitcoin data", Code = "BCHAIN"},
			new DataSource {Name = "Yahoo Finance", Count = 95000, Description = "US mutual funds and ETFs, global indexes", Code = "YAHOO"},
			new DataSource {Name = "Quandl", Count = 2500, Description = "Exchange rates", Code = "QUANDL"},
			new DataSource {Name = "Nikkei Group", Count = 15, Description = "Daily indexes published by the Nikkei group.", Code = "NIKKEI"},
			new DataSource {Name = "Renaissance Capital", Count = 5, Description = "Monthly US IPO statistics.", Code = "RENCAP"},
			new DataSource {Name = "World Federation of Exchanges", Count = 250, Description = "Comparative market statistics for exchanges around the world", Code = "WFE"},
			new DataSource {Name = "World Gold Council", Count = 200, Description = "Gold prices", Code = "WGC"},
			new DataSource {Name = "Wren Research", Count = 15, Description = "Australian stock performance", Code = "WREN"},
			new DataSource {Name = "Stock Exchange of Thailand", Count = 5, Description = "Thai market Indexes", Code = "THAISE"},
			new DataSource {Name = "Wall Street Journal", Count = 120, Description = "Commodity spot prices", Code = "WSJ"},
			new DataSource {Name = "Philippine Stock Exchange", Count = 10, Description = "Filipino stock exchange", Code = "PHILSE"},
			new DataSource {Name = "Australian Securities Exchange", Count = 350, Description = "Australian and New Zealand equity, rate and commodity futures", Code = "ASX"},
			new DataSource {Name = "Eurex", Count = 1200, Description = "Schatz, Bobl, Bund, Buxl, BTP, OAT, DAX, Stoxx, equity and commodity futures.", Code = "EUREX"},
			new DataSource {Name = "Euronext LIFFE", Count = 1700, Description = "Gilts, short sterling, FTSE and London commodity futures.", Code = "LIFFE"},
			new DataSource {Name = "Minneapolis Grain Exchange", Count = 800, Description = "Grain futures traded on the Minneapolis Grain Exchange", Code = "MGEX"},
			new DataSource {Name = "Price-Data.com", Count = 1700, Description = "Delisted futures contracts including HU, PB, DM, FR, CR, KV.", Code = "PXDATA"},
			new DataSource {Name = "Budapest Stock Exchange", Count = 5, Description = "Hungarian stock exchange", Code = "BUDAPESTSE"},
			new DataSource {Name = "Singapore Exchange", Count = 800, Description = "Contracts including equities, commodites, forex and rates", Code = "SGX"},
			new DataSource {Name = "Eurekahedge", Count = 250, Description = "Hedge fund performance data", Code = "EUREKA"},
			new DataSource {Name = "Merrill Lynch", Count = 25, Description = "US bonds and equities", Code = "ML"}

			// Not implemented
			//new DataSource {Name = "Standard and Poor's", Count = 450, Description = "Housing and equity indexes including Case-Shiller", Code = "SANDP"},
			//new DataSource {Name = "Open Financial Data Project", Count = 18000, Description = "Futures (CME, ICE, CFTC), indexes (WSJ), financial ratios (Damodaran) and more", Code = "OFDP"},
			//new DataSource {Name = "PsychSignal", Count = 14000, Description = "Bullish/bearish sentiment index and sentiment volume ratios for thousands of stocks.", Code = "PSYCH"},
			//new DataSource {Name = "NASDAQ OMX", Count = 41500, Description = "Data for NASDAQ OMX indices", Code = "NASDAQ"},
			//new DataSource {Name = "National Stock Exchange of India", Count = 2000, Description = "India equities", Code = "NSE"},
			//new DataSource {Name = "NYSE Euronext", Count = 1500, Description = "European equities", Code = "NYX"},
			//new DataSource {Name = "IntercontinentalExchange", Count = 6500, Description = "Commodities exchange for energy, agriculture, credit, currenc, emissions and equity index products", Code = "ICE"},
			//new DataSource {Name = "Shanghai Futures Exchange", Count = 1100, Description = "Various futures traded on the Shanghai Futures Exchange", Code = "SHFE"},
			//new DataSource {Name = "Chicago Board Options Exchange", Count = 600, Description = "Volatility indexes and futures", Code = "CBOE"},
			//new DataSource {Name = "The Montreal Exchange", Count = 500, Description = "Futures contracts over a number of different deliverables", Code = "MX"},
			//new DataSource {Name = "Swiss Exchange", Count = 300, Description = "End of day data for the Swiss Exchange", Code = "SIX"},
			//new DataSource {Name = "Bitcoin Charts", Count = 200, Description = "Bitcoin market price data", Code = "BITCOIN"},
			//new DataSource {Name = "Bursa Malaysia", Count = 80, Description = "Palm oil, KLIBOR and Malaysian interest rate futures", Code = "MYX"},
			//new DataSource {Name = "Osaka Securities Exchange", Count = 90, Description = "Nikkei and Nikkei volatility futures.", Code = "OSE"},
			//new DataSource {Name = "Asian Bond Market Initiative", Count = 40, Description = "ASEAN database on bond issuance in South East Asia", Code = "ABMI"},
			//new DataSource {Name = "Osaka Dojima Commodity Exchange", Count = 90, Description = "Japanese commodity futures in the Kansai market", Code = "ODE"},
			//new DataSource {Name = "Amman Stock Exchange", Count = 30, Description = "Jordanian stock exchange", Code = "AMMANSE"},
			//new DataSource {Name = "Unicorn Research Corporation", Count = 30, Description = "Number and volume of various stock exchanges", Code = "URC"},
			//new DataSource {Name = "University of Stavanger", Count = 25, Description = "Norwegian equities", Code = "UIS"},
			//new DataSource {Name = "MoneyTree Report", Count = 10, Description = "Quarterly studies of venture capital investment activity", Code = "MONEYTREE"},
			//new DataSource {Name = "Policy Uncertainty Project", Count = 10, Description = "Indices of economic policy uncertainty for world's major economies", Code = "PUP"},
			//new DataSource {Name = "Beta Arbitrage", Count = 10, Description = "Minimum variance portfolios and beta portfolios for various equity indexes.", Code = "BARB"}
		};
	}
}
