namespace Interface
{
    public class Calculator : ICalculator
    {
        public int Sum(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
            return numberOne + numberTwo;
        }
        public int Substract(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne - numberTwo);
            return numberOne - numberTwo;
        }
        public int Multiply(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne * numberTwo);
            return numberOne * numberTwo;
        }
        public int Divide(int numberOne, int numberTwo)
        {
            if (numberTwo == 0)
            {
                Console.WriteLine("Error: Cannot divide to zero");
                return 0;
            }
            Console.WriteLine(numberOne / numberTwo);
            return numberOne / numberTwo;
        }
        void ICalculator.Calculate(int numberOne, int numbeTwo)
        {
            throw new NotImplementedException();
        }
    }
}