using cyrkat.common.errors;

namespace cyrkat.common.results
{
	public class Result<T>
	{
		internal Result(T value)
		{
			Value = value;
		}

		internal Result(Error error)
		{
			Error = error;
		}

		public readonly T Value;
		public readonly Error Error;

		public static Result<T> SucceedWith(T value)
		{
			return new Result<T>(value);
		}

		public static Result<T> FailedWith(Error error)
		{
			return new Result<T>(error);
		}
	}
}
