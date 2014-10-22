#region Usings

using System;

#endregion

namespace FinancialCharting.Library.ProjectExceptions
{
	[Serializable]
	public class IndicatorException : Exception
	{
		public IndicatorException()
			: base("Invalid indicator parameters")
		{}

		public IndicatorException(string message)
			: base(message)
		{}

		public IndicatorException(Exception inner)
			: base("Invalid indicator parameters", inner)
		{}

		public IndicatorException(string message, Exception inner)
			: base(message, inner)
		{}
	}
}
