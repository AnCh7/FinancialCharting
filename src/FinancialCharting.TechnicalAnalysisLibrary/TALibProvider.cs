#region Usings

using System;
using System.Collections.Generic;
using System.Linq;

using FinancialCharting.Library.Logging;
using FinancialCharting.Library.Models.Common;
using FinancialCharting.Library.Models.Indicator;
using FinancialCharting.Library.ProjectExceptions;
using FinancialCharting.TechnicalAnalysisLibrary.Interfaces;

using TicTacTec.TA.Library;

#endregion

namespace FinancialCharting.TechnicalAnalysisLibrary
{
	public class TALibProvider : ITALibProvider
	{
		private readonly ILogWrapper _logger;

		public TALibProvider(ILogWrapper logger)
		{
			_logger = logger;
		}

		public OperationResult<IndicatorSeries> CalculateBbands(List<double> closes,
																int optInTimePeriod,
																double optInNbDevUp,
																double optInNbDevDn,
																Core.MAType optInMAType)
		{
			try
			{
				var length = closes.Count();

				var endIdx = length - 1;
				var inReal = closes.ToArray();

				int outBegIdx;
				int outNBElement;
				var outRealUpperBand = new double[length];
				var outRealMiddleBand = new double[length];
				var outRealLowerBand = new double[length];

				var retCode = Core.Bbands(0,
										  endIdx,
										  inReal,
										  optInTimePeriod,
										  optInNbDevUp,
										  optInNbDevDn,
										  optInMAType,
										  out outBegIdx,
										  out outNBElement,
										  outRealUpperBand,
										  outRealMiddleBand,
										  outRealLowerBand);

				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorTripleSeries(outBegIdx, outNBElement, outRealUpperBand, outRealMiddleBand, outRealLowerBand));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}

		public OperationResult<IndicatorSeries> CalculateRsi(List<double> closes, int optInTimePeriod)
		{
			try
			{
				var length = closes.Count();

				var endIdx = length - 1;
				var inReal = closes.ToArray();

				int outBegIdx;
				int outNBElement;
				var outReal = new double[length];

				var retCode = Core.Rsi(0, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorSingleSeries(outBegIdx, outNBElement, outReal));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}

		public OperationResult<IndicatorSeries> CalculateStoch(List<double> highs,
															   List<double> lows,
															   List<double> closes,
															   int optInFastKPeriod,
															   int optInSlowKPeriod,
															   Core.MAType optInSlowKMAType,
															   int optInSlowDPeriod,
															   Core.MAType optInSlowDMAType)
		{
			try
			{
				var length = closes.Count();

				var endIdx = length - 1;
				var inHigh = highs.ToArray();
				var inLow = lows.ToArray();
				var inClose = closes.ToArray();

				int outBegIdx;
				int outNBElement;
				var outSlowK = new double[length];
				var outSlowD = new double[length];

				var retCode = Core.Stoch(0,
										 endIdx,
										 inHigh,
										 inLow,
										 inClose,
										 optInFastKPeriod,
										 optInSlowKPeriod,
										 optInSlowKMAType,
										 optInSlowDPeriod,
										 optInSlowDMAType,
										 out outBegIdx,
										 out outNBElement,
										 outSlowK,
										 outSlowD);
				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorDoubleSeries(outBegIdx, outNBElement, outSlowK, outSlowD));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}

		public OperationResult<IndicatorSeries> CalculateAroonOsc(List<double> highs, List<double> lows, int optInTimePeriod)
		{
			try
			{
				var length = highs.Count();

				var endIdx = length - 1;
				var inHigh = highs.ToArray();
				var inLow = lows.ToArray();

				int outBegIdx;
				int outNBElement;
				var outReal = new double[length];

				var retCode = Core.AroonOsc(0,
											endIdx,
											inHigh,
											inLow,
											optInTimePeriod,
											out outBegIdx,
											out outNBElement,
											outReal);
				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorSingleSeries(outBegIdx, outNBElement, outReal));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}

		public OperationResult<IndicatorSeries> CalculateAroon(List<double> highs, List<double> lows, int optInTimePeriod)
		{
			try
			{
				var length = highs.Count();

				var endIdx = length - 1;
				var inHigh = highs.ToArray();
				var inLow = lows.ToArray();

				int outBegIdx;
				int outNBElement;
				var outAroonDown = new double[length];
				var outAroonUp = new double[length];

				var retCode = Core.Aroon(0,
										 endIdx,
										 inHigh,
										 inLow,
										 optInTimePeriod,
										 out outBegIdx,
										 out outNBElement,
										 outAroonDown,
										 outAroonUp);

				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorDoubleSeries(outBegIdx, outNBElement, outAroonDown, outAroonUp));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}

		public OperationResult<IndicatorSeries> CalculateAdx(List<double> highs, List<double> lows, List<double> closes, int optInTimePeriod)
		{
			try
			{
				var length = closes.Count();

				var endIdx = length - 1;
				var inHigh = highs.ToArray();
				var inLow = lows.ToArray();
				var inClose = closes.ToArray();

				int outBegIdx;
				int outNBElement;
				var outReal = new double[length];
				var outMinusReal = new double[length];
				var outPlusReal = new double[length];

				Core.MinusDI(0,
							 endIdx,
							 inHigh,
							 inLow,
							 inClose,
							 optInTimePeriod,
							 out outBegIdx,
							 out outNBElement,
							 outMinusReal);

				Core.PlusDI(0,
							endIdx,
							inHigh,
							inLow,
							inClose,
							optInTimePeriod,
							out outBegIdx,
							out outNBElement,
							outPlusReal);

				var retCode = Core.Adx(0,
									   endIdx,
									   inHigh,
									   inLow,
									   inClose,
									   optInTimePeriod,
									   out outBegIdx,
									   out outNBElement,
									   outReal);

				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorTripleSeries(outBegIdx, outNBElement, outReal, outMinusReal, outPlusReal));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}

		public OperationResult<IndicatorSeries> CalculateSma(List<double> closes, int optInTimePeriod)
		{
			try
			{
				var length = closes.Count();

				var endIdx = length - 1;
				var inReal = closes.ToArray();

				int outBegIdx;
				int outNBElement;
				var outReal = new double[length];

				var retCode = Core.Sma(0, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorSingleSeries(outBegIdx, outNBElement, outReal));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}

		public OperationResult<IndicatorSeries> CalculateEma(List<double> closes, int optInTimePeriod)
		{
			try
			{
				var length = closes.Count();

				var endIdx = length - 1;
				var inReal = closes.ToArray();

				int outBegIdx;
				int outNBElement;
				var outReal = new double[length];

				var retCode = Core.Ema(0, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorSingleSeries(outBegIdx, outNBElement, outReal));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}

		public OperationResult<IndicatorSeries> CalculateWma(List<double> closes, int optInTimePeriod)
		{
			try
			{
				var length = closes.Count();

				var endIdx = length - 1;
				var inReal = closes.ToArray();

				int outBegIdx;
				int outNBElement;
				var outReal = new double[length];

				var retCode = Core.Wma(0, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorSingleSeries(outBegIdx, outNBElement, outReal));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}

		public OperationResult<IndicatorSeries> CalculateMacd(List<double> closes,
															  int optInFastPeriod,
															  int optInSlowPeriod,
															  int optInSignalPeriod)
		{
			try
			{
				var length = closes.Count();

				var endIdx = length - 1;
				var inReal = closes.ToArray();

				int outBegIdx;
				int outNBElement;
				var outMacd = new double[length];
				var outMacdHist = new double[length];
				var outMacdSignal = new double[length];

				var retCode = Core.Macd(0,
										endIdx,
										inReal,
										optInFastPeriod,
										optInSlowPeriod,
										optInSignalPeriod,
										out outBegIdx,
										out outNBElement,
										outMacd,
										outMacdSignal,
										outMacdHist);

				if (retCode == Core.RetCode.Success)
				{
					return new OperationResult<IndicatorSeries>(new IndicatorTripleSeries(outBegIdx, outNBElement, outMacd, outMacdHist, outMacdSignal));
				}
				else
				{
					return new OperationResult<IndicatorSeries>(false, retCode.ToString());
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				throw new TALibException(ex);
			}
		}
	}
}
