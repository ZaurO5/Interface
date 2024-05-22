using Interface;
class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
    Initalize: Console.WriteLine("Please Enter operator");
        string _operator = Console.ReadLine();
        switch (_operator)
        {
            case "+":
                calculator.Sum(10, 2);
                break;
            case "-":
                calculator.Substract(10, 2);
                break;
            case "*":
                calculator.Multiply(10, 2);
                break;
            case "/":
                calculator.Divide(10, 2);
                break;
            default:
                Console.WriteLine("Wrong operator, please try again");
                goto Initalize;
        }
    }
}