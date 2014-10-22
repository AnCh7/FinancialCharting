#region Usings

using System;

#endregion

namespace FinancialCharting.Library.ProjectExceptions
{
	[Serializable]
	public class TALibException : Exception
	{
		public TALibException(Exception inner)
			: base("Indicator calculation failed", inner)
		{}
	}
}
