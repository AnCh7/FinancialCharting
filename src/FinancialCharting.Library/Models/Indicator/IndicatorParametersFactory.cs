#region Usings

using System;

using FinancialCharting.Library.Enum;
using FinancialCharting.Library.Logging;
using FinancialCharting.Library.ProjectExceptions;

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

		public static BaseIndicatorParameters Create(IndicatorType indicatorType, int period1, int? period2, int? period3)
		{
			try
			{
				switch (indicatorType)
				{
					case IndicatorType.BBANDS:
						if (!period2.HasValue || !period3.HasValue)
						{
							throw new IndicatorException();
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
							throw new IndicatorException();
						}
						return new StochParameters(indicatorType, period1, period2.Value, period3.Value);

					case IndicatorType.MACD:
						if (!period2.HasValue || !period3.HasValue)
						{
							throw new IndicatorException();
						}
						return new MacdParameters(indicatorType, period1, period2.Value, period3.Value);

					default:
						throw new IndicatorException("Not supported indicator");
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new IndicatorException(ex);
			}
		}
	}
}
