#region Usings

using System;

#endregion

namespace FinancialCharting.Library.ProjectExceptions
{
	[Serializable]
	public class ParsingException : Exception
	{
		public ParsingException()
			: base("Parsing failed")
		{}

		public ParsingException(string message)
			: base(message)
		{}

		public ParsingException(Exception inner)
			: base("Parsing failed", inner)
		{}

		public ParsingException(string message, Exception inner)
			: base(message, inner)
		{}
	}
}
