using System;
using System.Runtime.Serialization;

namespace Explan.Backend.Common.Exceptions
{
	public class ForbidenException : DomainException
	{
		public ForbidenException()
		{
		}

		public ForbidenException(string message) : base(message)
		{
		}

		public ForbidenException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ForbidenException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
