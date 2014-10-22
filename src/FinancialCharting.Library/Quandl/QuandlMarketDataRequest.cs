#region Usings

using System;

using FinancialCharting.Library.Enum;

#endregion

namespace FinancialCharting.Library.Quandl
{
	public class QuandlMarketDataRequest
	{
		public QuandlMarketDataRequest(string dataSource,
									   string ticker,
									   DateTime? from,
									   DateTime? to,
									   int? rowsNumber,
									   TimeframeType? timeframe,
									   TransformationType? transformation)
		{
			DataSource = dataSource;
			Ticker = ticker;
			FromDate = from;
			ToDate = to;
			RowsNumber = rowsNumber;
			Timeframe = timeframe;
			Transformation = transformation;
			SortOrder = SortOrderType.ASC;
			ExcludeHeaders = false;
			SpecificColumnNumber = null;
		}

		public string DataSource { get; set; }

		public string Ticker { get; set; }

		private DateTime? FromDate { get; set; }

		private DateTime? ToDate { get; set; }

		public string From
		{
			get
			{
				if (FromDate.HasValue)
				{
					return FromDate.Value.ToString("yyyy-MM-dd");
				}
				else
				{
					return string.Empty;
				}
			}
		}

		public string To
		{
			get
			{
				if (ToDate.HasValue)
				{
					return ToDate.Value.ToString("yyyy-MM-dd");
				}
				else
				{
					return string.Empty;
				}
			}
		}

		public SortOrderType? SortOrder { get; set; }

		public int? RowsNumber { get; set; }

		public TimeframeType? Timeframe { get; set; }

		public TransformationType? Transformation { get; set; }

		public bool ExcludeHeaders { get; private set; }

		public int? SpecificColumnNumber { get; private set; }
	}
}
