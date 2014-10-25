#region Usings

using System;

#endregion

namespace FinancialCharting.Library.ProjectExceptions
{
	[Serializable]
	public class TALibException : Exception
	{
		public TALibException()
			: base("Indicator calculation failed")
		{}

		public TALibException(string message)
			: base(message)
		{}

		public TALibException(Exception inner)
			: base("Indicator calculation failed", inner)
		{}

		public TALibException(string message, Exception inner)
			: base(message, inner)
		{}
	}
}
