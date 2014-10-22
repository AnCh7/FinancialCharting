#region Usings

using System;

#endregion

namespace FinancialCharting.Library.ProjectExceptions
{
	[Serializable]
	public class QuandlProviderException : Exception
	{
		public QuandlProviderException(string message, Exception inner)
			: base(message, inner)
		{}

		public QuandlProviderException(Exception inner)
			: base("Loading failed", inner)
		{}
	}
}
