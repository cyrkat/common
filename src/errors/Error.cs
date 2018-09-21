namespace cyrkat.common.errors
{
	public class Error
	{
		private Error(string code, string message)
		{
			Code = code;
			Message = message;
		}

		public readonly string Code;
		public readonly string Message;
	}
}
