#region Usings

using System;

using FinancialCharting.Library.Enum;
using FinancialCharting.Library.Logging;

#endregion

namespace FinancialCharting.Library.Models.Indicator
{
	public class IndicatorParametersFactory
	{
		private static ILogWrapper _logger;

		public IndicatorParametersFactory(ILogWrapper logger)
		{
			_logger = logger;
		}

		public static BaseIndicatorParameters Create(IndicatorType indicatorType, int period1, int? period2 = null, int? period3 = null)
		{
			try
			{
				switch (indicatorType)
				{
					case IndicatorType.BBANDS:
						if (!period2.HasValue || !period3.HasValue)
						{
							throw new ArgumentException();
						}
						return new BBandsParameters(indicatorType, period1, period2.Value, period3.Value);

					case IndicatorType.ADX:
						return new AdxParameters(indicatorType, period1);

					case IndicatorType.RSI:
						return new RsiParameters(indicatorType, period1);

					case IndicatorType.WMA:
						return new WmaParameters(indicatorType, period1);

					case IndicatorType.AROONOSC:
						return new AroonOscParameters(indicatorType, period1);

					case IndicatorType.AROON:
						return new AroonParameters(indicatorType, period1);

					case IndicatorType.SMA:
						return new SmaParameters(indicatorType, period1);

					case IndicatorType.EMA:
						return new EmaParameters(indicatorType, period1);

					case IndicatorType.STOCH:
						if (!period2.HasValue || !period3.HasValue)
						{
							throw new ArgumentException();
						}
						return new StochParameters(indicatorType, period1, period2.Value, period3.Value);

					case IndicatorType.MACD:
						if (!period2.HasValue || !period3.HasValue)
						{
							throw new ArgumentException();
						}
						return new MacdParameters(indicatorType, period1, period2.Value, period3.Value);
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
			}

			return null;
		}
	}
}
