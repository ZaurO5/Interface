class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter birthdate: ");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime birthDate))
        {
            int age = birthDate.CalculateAge();
            Console.WriteLine($"your age: {age}");
        }
        else
        {
            Console.WriteLine("Wrong Format");
        }
    }
}
