﻿using System;
using System.Runtime.Serialization;

namespace Explan.Backend.Common.Exceptions
{
	public class BadRequestException : DomainException
	{
		public BadRequestException()
		{
		}

		public BadRequestException(string message) : base(message)
		{
		}

		public BadRequestException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected BadRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
