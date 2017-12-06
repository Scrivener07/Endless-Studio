using System;
using System.Runtime.Serialization;


namespace Sharp.Applications
{
	[Serializable]
	public class ArgumentContextException : ArgumentException
	{
		public ArgumentContextException()
			: base() { }

		public ArgumentContextException(string message)
			: base(message) { }

		public ArgumentContextException(string format, params object[] args)
			: base(String.Format(format, args)) { }

		public ArgumentContextException(string message, Exception innerException)
			: base(message, innerException) { }

		public ArgumentContextException(string format, Exception innerException, params object[] args)
			: base(String.Format(format, args), innerException) { }

		protected ArgumentContextException(SerializationInfo info, StreamingContext context)
			: base(info, context) { }
	}
}
