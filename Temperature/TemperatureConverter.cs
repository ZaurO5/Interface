namespace Temperature
{
    public static class TemperatureConverter
    {
        public static int CelsiumToFahrenheit(int number)
        {
            return (int)((number * 9 / 5) +32);
        }
        public static int FahrenheitToCelsium(int number)
        {
            return (int)((number - 32) * 5 / 9);
        }
    }
}
