using System;
using System.Runtime.Serialization;

namespace C2.Controllers
{
    [Serializable]
    internal class RetryLimiExceededException : Exception
    {
        public RetryLimiExceededException()
        {
        }

        public RetryLimiExceededException(string message) : base(message)
        {
        }

        public RetryLimiExceededException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RetryLimiExceededException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}