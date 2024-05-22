public static class StringExtensions
{
    public static string Reverse(this string str)
    {
        if (str == null)
        {
            throw new Exception(nameof(str));
        }

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
