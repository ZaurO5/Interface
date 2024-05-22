class Program
{
    static void Main(string[] args)
    {
        try
        {
            User user1 = new User("Zaur", "Huseynov", RegistrationMonth.January, "1QW23EZ");
            User user2 = new User("Ali", "Aliyev", RegistrationMonth.February, "4RT56YA");
            User user3 = new User("Emil", "Quliyev", RegistrationMonth.March, "7UI89OE");
            User user4 = new User("Rakhman", "Seyidov", RegistrationMonth.April, "0PQ12WR");
            User user5 = new User("Said", "Memmedov", RegistrationMonth.May, "3ER45TS");

            Console.WriteLine(user1.GetDetails());
            Console.WriteLine(user2.GetDetails());
            Console.WriteLine(user3.GetDetails());
            Console.WriteLine(user4.GetDetails());
            Console.WriteLine(user5.GetDetails());
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
