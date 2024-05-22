namespace Polindrom
{
    public static class StringExtensions
    {
        public static string? ReverseWord(string str)
        {
            if (str == null)
            {
                return null;
            }
            return new string(str.ToCharArray().Reverse().ToArray());
        }
    }
}

