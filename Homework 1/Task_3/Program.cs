using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string fNumber = Console.ReadLine();

            Console.WriteLine("Enter second number");
            string sNumber = Console.ReadLine();

            bool isFirstOk = int.TryParse(fNumber, out int firstNumber);
            bool isSecondOk = int.TryParse(sNumber, out int secondNumber);

            int swapNumber = 0;

            if (isFirstOk && isSecondOk)
            {
                swapNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = swapNumber;
                Console.WriteLine("After SWAPING");
                Console.WriteLine($"First number {firstNumber}");
                Console.WriteLine($"Second number {secondNumber}");
            }
            else
            {
                Console.WriteLine("Wrong number input!!!");
            }
        }
    }
}
