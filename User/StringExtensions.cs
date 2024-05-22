public static class StringExtensions
{
    public static bool IsValidPIN(this string pin)
    {
        if (pin.Length != 7)
        {
            return false;
        }

        foreach (char c in pin)
        {
            if (!char.IsUpper(c) && !char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}
