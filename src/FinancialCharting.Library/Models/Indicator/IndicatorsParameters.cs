#region Usings

using FinancialCharting.Library.Enum;

#endregion

namespace FinancialCharting.Library.Models.Indicator
{
	public class BaseIndicatorParameters
	{
		protected BaseIndicatorParameters(IndicatorType type)
		{
			Type = type;
		}

		public IndicatorType Type { get; private set; }
		public int Period { get; protected set; }
	}

	public class AdxParameters : BaseIndicatorParameters
	{
		public AdxParameters(IndicatorType type, int period)
			: base(type)
		{
			base.Period = period;
		}
	}

	public class AroonOscParameters : BaseIndicatorParameters
	{
		public AroonOscParameters(IndicatorType type, int period)
			: base(type)
		{
			base.Period = period;
		}
	}

	public class AroonParameters : BaseIndicatorParameters
	{
		public AroonParameters(IndicatorType type, int period)
			: base(type)
		{
			base.Period = period;
		}
	}

	public class BBandsParameters : BaseIndicatorParameters
	{
		public BBandsParameters(IndicatorType type, int period, int deviationUp, int deviationDn)
			: base(type)
		{
			base.Period = period;
			DeviationUp = deviationUp;
			DeviationDn = deviationDn;
		}

		public double DeviationUp { get; private set; }
		public double DeviationDn { get; private set; }
	}

	public class EmaParameters : BaseIndicatorParameters
	{
		public EmaParameters(IndicatorType type, int period)
			: base(type)
		{
			base.Period = period;
		}
	}

	public class MacdParameters : BaseIndicatorParameters
	{
		public MacdParameters(IndicatorType type, int fastPeriod, int slowPeriod, int signalPeriod)
			: base(type)
		{
			FastPeriod = fastPeriod;
			SlowPeriod = slowPeriod;
			SignalPeriod = signalPeriod;
		}

		public int FastPeriod { get; private set; }
		public int SlowPeriod { get; private set; }
		public int SignalPeriod { get; private set; }
	}

	public class RsiParameters : BaseIndicatorParameters
	{
		public RsiParameters(IndicatorType type, int period)
			: base(type)
		{
			base.Period = period;
		}
	}

	public class SmaParameters : BaseIndicatorParameters
	{
		public SmaParameters(IndicatorType type, int period)
			: base(type)
		{
			base.Period = period;
		}
	}

	public class StochParameters : BaseIndicatorParameters
	{
		public StochParameters(IndicatorType type, int fastKPeriod, int slowKPeriod, int slowDPeriod)
			: base(type)
		{
			FastKPeriod = fastKPeriod;
			SlowKPeriod = slowKPeriod;
			SlowDPeriod = slowDPeriod;
		}

		public int FastKPeriod { get; private set; }
		public int SlowKPeriod { get; private set; }
		public int SlowDPeriod { get; private set; }
	}

	public class WmaParameters : BaseIndicatorParameters
	{
		public WmaParameters(IndicatorType type, int period)
			: base(type)
		{
			base.Period = period;
		}
	}
}
