using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string fNumString = Console.ReadLine();

            Console.WriteLine("Enter second number");
            string sNumString = Console.ReadLine();

            Console.WriteLine("Enter third number");
            string tNumString = Console.ReadLine();

            Console.WriteLine("Enter forth number");
            string fourthNumString = Console.ReadLine();

            bool isFirstOk = int.TryParse(fNumString, out int firsNumber);
            bool isSecondOk = int.TryParse(sNumString, out int secondNumber);
            bool isThirdOk = int.TryParse(tNumString, out int thirdNumber);
            bool isFourthOk = int.TryParse(fourthNumString, out int fourthNumber);
            int sumAvg = 0;

            if (isFirstOk && isSecondOk && isThirdOk && isFourthOk)
            {
                sumAvg = (firsNumber + secondNumber + thirdNumber + fourthNumber) / 4;
                if (sumAvg == 0)
                {
                    Console.WriteLine("Cannot calculate average of 0");
                }
                else 
                {
                    Console.WriteLine($"You average of 4 numbers is {sumAvg}");
                }

            }
            else
            {
                Console.WriteLine("Wrong number input!!!");
            }

        }
    }
}
