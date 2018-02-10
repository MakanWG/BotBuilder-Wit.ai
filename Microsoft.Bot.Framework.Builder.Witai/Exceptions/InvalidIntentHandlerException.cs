using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Bot.Framework.Builder.Witai.Exceptions
{
	[Serializable]
	internal class InvalidIntentHandlerException : Exception
	{
		private MethodInfo method;
		private string v;

		public InvalidIntentHandlerException()
		{
		}

		public InvalidIntentHandlerException(string message) : base(message)
		{
		}

		public InvalidIntentHandlerException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public InvalidIntentHandlerException(string v, MethodInfo method)
		{
			this.v = v;
			this.method = method;
		}

		protected InvalidIntentHandlerException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
