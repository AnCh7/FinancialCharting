#region Usings

using System.Collections.Generic;

using FinancialCharting.Library.Models.Common;
using FinancialCharting.Library.Models.Indicator;

using TicTacTec.TA.Library;

#endregion

namespace FinancialCharting.TechnicalAnalysisLibrary.Interfaces
{
	public interface ITALibProvider
	{
		OperationResult<IndicatorSeries> CalculateBbands(List<double> closes,
														 int optInTimePeriod,
														 double optInNbDevUp,
														 double optInNbDevDn,
														 Core.MAType optInMAType);

		OperationResult<IndicatorSeries> CalculateRsi(List<double> closes, int optInTimePeriod);

		OperationResult<IndicatorSeries> CalculateStoch(List<double> highs,
														List<double> lows,
														List<double> closes,
														int optInFastKPeriod,
														int optInSlowKPeriod,
														Core.MAType optInSlowKMAType,
														int optInSlowDPeriod,
														Core.MAType optInSlowDMAType);

		OperationResult<IndicatorSeries> CalculateAroonOsc(List<double> highs, List<double> lows, int optInTimePeriod);

		OperationResult<IndicatorSeries> CalculateAroon(List<double> highs, List<double> lows, int optInTimePeriod);

		OperationResult<IndicatorSeries> CalculateAdx(List<double> highs, List<double> lows, List<double> closes, int optInTimePeriod);

		OperationResult<IndicatorSeries> CalculateSma(List<double> closes, int optInTimePeriod);

		OperationResult<IndicatorSeries> CalculateEma(List<double> closes, int optInTimePeriod);

		OperationResult<IndicatorSeries> CalculateWma(List<double> closes, int optInTimePeriod);

		OperationResult<IndicatorSeries> CalculateMacd(List<double> closes,
													   int optInFastPeriod,
													   int optInSlowPeriod,
													   int optInSignalPeriod);
	}
}
