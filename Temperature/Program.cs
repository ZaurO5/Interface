using Temperature;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter temperature: ");
        int temperature = int.Parse(Console.ReadLine());

        Console.WriteLine("Is this temperature in (C)elsius or (F)ahrenheit?");
        string scale = Console.ReadLine().ToUpper();

        if (scale == "C")
        {
            int fahrenheit = TemperatureConverter.CelsiumToFahrenheit(temperature);
            Console.WriteLine($"{temperature}°C is {fahrenheit}°F");
        }
        else if (scale == "F")
        {
            int celsius = TemperatureConverter.FahrenheitToCelsium(temperature);
            Console.WriteLine($"{temperature}°F is {celsius}°C");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
        }
    }
}