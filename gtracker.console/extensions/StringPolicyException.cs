using System;

namespace gtask_tracker.console
{
    internal class StringPolicyException : Exception
    {
        public StringPolicyException()
        {
        }

        public StringPolicyException(string? message) : base(message)
        {
        }

        public StringPolicyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
