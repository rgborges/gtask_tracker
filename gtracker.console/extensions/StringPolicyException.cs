using System.Runtime.Serialization;

[Serializable]
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

    protected StringPolicyException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}