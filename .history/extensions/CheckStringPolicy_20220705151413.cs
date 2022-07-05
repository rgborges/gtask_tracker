public static class CheckStringPolicy
{
    public static void Check(string input)
    {
        if(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input)){
            throw new StringPolicyException(
                
            );
        }
    }
}