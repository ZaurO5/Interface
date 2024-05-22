internal class BirthDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
        
    public static void YourBirthDate(int day, int month, int year)
    {
        Console.WriteLine($"{day}.{month}.{year}");
    }
}

