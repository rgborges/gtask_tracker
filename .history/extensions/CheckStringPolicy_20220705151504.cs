public static class CheckStringPolicy
{
    public static void Check(string input)
    {
        if(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input)){
            throw new StringPolicyException(
                "Object was blocked to be mounted by internal application stirng policy. Check if any of strings are null or "
            );
        }
    }
}