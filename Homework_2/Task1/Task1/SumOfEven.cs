using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2.Task1
{
    class SumOfEven
    {
        static void Main(string[] args)
        {
            string inputNum;
            int[] arrayOfNumbers = new int[6];
            int sumOfEvenNumbers = 0;
            Console.WriteLine("Enter array of 6 numbers, one by one");
            for (int counter = 0; counter < 6; counter++)
            {
                inputNum = Console.ReadLine();
                bool isInputOk = int.TryParse(inputNum, out int parsedNumber);
                if (isInputOk)
                {
                    arrayOfNumbers[counter] = parsedNumber;
                    if (arrayOfNumbers[counter] % 2 == 0)
                    {
                        sumOfEvenNumbers += arrayOfNumbers[counter];
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("You didnt enter number!");
                }
            }
            Console.WriteLine($"Sum of all even numbers in array is {sumOfEvenNumbers}");
         }
    }

}
