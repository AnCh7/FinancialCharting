#region Usings

using System;

#endregion

namespace FinancialCharting.Library.Logging
{
	public interface ILogWrapper
	{
		void Error(string message);

		void Error(Exception exception);

		void Warn(string message);
	}
}
