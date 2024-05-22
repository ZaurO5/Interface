class Program
{
    static void Main(string[] args)
    {
        int num = 17;
        if (MathUtils.IsPrime(num))
        {
            Console.WriteLine($"{num} is prime.");
        }
        else
        {
            Console.WriteLine($"{num} is not prime.");
        }
    }
}
