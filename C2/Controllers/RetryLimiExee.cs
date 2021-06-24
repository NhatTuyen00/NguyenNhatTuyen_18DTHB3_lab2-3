using System;
using System.Runtime.Serialization;

namespace C2.Controllers
{
    [Serializable]
    internal class RetryLimiExee : Exception
    {
        public RetryLimiExee()
        {
        }

        public RetryLimiExee(string message) : base(message)
        {
        }

        public RetryLimiExee(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RetryLimiExee(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}