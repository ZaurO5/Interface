public static class Program
{
    public static void Main()
    {
        int month = Convert.ToInt32 (Console.ReadLine());

        switch (month)
        {
            case (int)Months.January:
                Console.WriteLine("January, Winter");
                break;
            case (int)Months.February:
                Console.WriteLine("February, Winter");
                break;
            case (int)Months.March:
                Console.WriteLine("March, Spring");
                break;
            case (int)Months.April:
                Console.WriteLine("April, Spring");
                break;
            case (int)Months.May:
                Console.WriteLine("May, Spring");
                break;
            case (int)Months.June:
                Console.WriteLine("June, Summer");
                break;
            case (int)Months.July:
                Console.WriteLine("July, Summer");
                break;
            case (int)Months.August:
                Console.WriteLine("August, Summer");
                break;
            case (int)Months.September:
                Console.WriteLine("September, Autumn");
                break;
            case (int)Months.October:
                Console.WriteLine("October, Autumn");
                break;
            case (int)Months.November:
                Console.WriteLine("November, Autumn");
                break;
            case (int)Months.December:
                Console.WriteLine("December, Winter");
                break;
        }
    }
}