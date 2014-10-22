namespace FinancialCharting.Library.Models.Common
{
	public class OperationResult<T> : OperationResult
	{
		public readonly T Data;

		public OperationResult(bool success, string errorMessage) : base(success, errorMessage)
		{}

		public OperationResult(T data) : base(true, string.Empty)
		{
			Data = data;
		}
	}

	public class OperationResult
	{
		protected OperationResult(bool success, string errorMessage)
		{
			Success = success;
			ErrorMessage = errorMessage;
		}

		public bool Success { get; set; }

		public string ErrorMessage { get; set; }
	}
}
