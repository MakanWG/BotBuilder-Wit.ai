using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Bot.Framework.Builder.Witai.Exceptions
{
	[Serializable]
	internal class UnsupportedWitIntentException : Exception
	{
		public UnsupportedWitIntentException(string message) : base(message)
		{

		}
	}
}
