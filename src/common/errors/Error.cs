namespace cyrkat.common.errors
{
	public class Error
	{
		internal Error(string code, string message)
		{
			Code = code;
			Message = message;
		}

		public readonly string Code;
		public readonly string Message;

		public static Error Unknown(string message = null)
		{
			return new Error(ErrorCodes.Unknown, message);
		}

		public static Error NotFound(string message = null)
		{
			return new Error(ErrorCodes.NotFound, message);
		}
	}
}
