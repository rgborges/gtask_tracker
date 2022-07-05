using System.Runtime.Serialization;

public static class CheckStringPolicy
{
    public static void Check(string input)
    {
        if(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input)){
            throw new StringPolicyException()
        }
    }

    [Serializable]
    private class StringPolicyException : Exception
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

        protected StringPolicyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}