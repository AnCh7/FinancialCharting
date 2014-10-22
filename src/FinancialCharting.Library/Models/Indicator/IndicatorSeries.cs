namespace FinancialCharting.Library.Models.Indicator
{
	public abstract class IndicatorSeries
	{
		protected IndicatorSeries(int outBegIdx, int outNBElement)
		{
			OutBegIdx = outBegIdx;
			OutNBElement = outNBElement;
		}

		public int OutBegIdx { get; private set; }
		public int OutNBElement { get; private set; }
	}

	public class IndicatorSingleSeries : IndicatorSeries
	{
		public IndicatorSingleSeries(int outBegIdx, int outNBElement, double[] outReal1)
			: base(outBegIdx, outNBElement)
		{
			OutReal1 = outReal1;
		}

		public double[] OutReal1 { get; private set; }
	}

	public class IndicatorDoubleSeries : IndicatorSingleSeries
	{
		public IndicatorDoubleSeries(int outBegIdx, int outNBElement, double[] outReal1, double[] outReal2)
			: base(outBegIdx, outNBElement, outReal1)
		{
			OutReal2 = outReal2;
		}

		public double[] OutReal2 { get; private set; }
	}

	public class IndicatorTripleSeries : IndicatorDoubleSeries
	{
		public IndicatorTripleSeries(int outBegIdx, int outNBElement, double[] outReal1, double[] outReal2, double[] outReal3)
			: base(outBegIdx, outNBElement, outReal1, outReal2)
		{
			OutReal3 = outReal3;
		}

		public double[] OutReal3 { get; private set; }
	}
}
