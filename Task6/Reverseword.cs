public static class StringExtensions
{
    public static string Reverse(this string str)
    {
        if (str == null)
        {
            return null;
        }

        return new string(str.ToCharArray().Reverse().ToArray());
    }
}
