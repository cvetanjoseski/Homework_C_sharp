using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            string firstInputKeyboard = Console.ReadLine();

            Console.WriteLine("Enter second number ");
            string secondInputKeyboard = Console.ReadLine();

            Console.WriteLine("What operation you want to do?");
            string operationKeyboard = Console.ReadLine();

            bool isFirstOk = int.TryParse(firstInputKeyboard, out int firstNumber);
            bool isSecondOk = int.TryParse(secondInputKeyboard, out int secondNumber);

            if (isFirstOk && isSecondOk)
            {
                {        
                 switch (operationKeyboard)
                    {
                      case "+":
                            Console.WriteLine($"Your addition of two numbers is {firstNumber+secondNumber}");
                                break;
                      case "-":
                            Console.WriteLine($"Your subtraction of two numbers is {firstNumber - secondNumber}");
                            break;
                      case "/":
                            Console.WriteLine($"Your divison of two numbers is {firstNumber / secondNumber}");
                            break;
                      case "*":
                            Console.WriteLine($"Your multiplication of two numbers is {firstNumber * secondNumber}");
                            break;
                        default:
                            Console.WriteLine($"Invalid operation {operationKeyboard}  ");
                            break;
                    }   
                    
                    
                }
            }
            else
            {
                Console.WriteLine("Wrong number input!!!");
            }
        }
    }
}
