#region Usings

using System;

#endregion

namespace FinancialCharting.Library.ProjectExceptions
{
	[Serializable]
	public class QuandlProviderException : Exception
	{
		public QuandlProviderException()
			: base("Loading failed")
		{}

		public QuandlProviderException(string message)
			: base(message)
		{}

		public QuandlProviderException(Exception inner)
			: base("Loading failed", inner)
		{}

		public QuandlProviderException(string message, Exception inner)
			: base(message, inner)
		{}
	}
}
