using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2.Task2
{
    class StudentGroup
    {
        static void Main(string[] args)
        {
            string[] studentsGOne = { "Stefan", "Petar", "Simona", "Renata", "Hristijan" };
            string[] studentsGTwo = { "Cvetan", "David", "Petar", "Hristina", "Stefani" };
            string inputGroupCheck;
            Console.WriteLine("Which group students you want to print? 1/2");
            inputGroupCheck = Console.ReadLine();
            if(inputGroupCheck == "1")
            {
                Console.WriteLine("Students in group One are: ");
                for(int counter = 0; counter<5; counter++)
                {
                    Console.WriteLine($"{studentsGOne[counter]}");
                }
            }
            else if(inputGroupCheck == "2")
            {
                Console.WriteLine("Students in group Two are: ");
                for (int counter = 0; counter < 5; counter++)
                {
                    Console.WriteLine($"{studentsGTwo[counter]}");
                }
            }
            else
            {
                Console.WriteLine("You enter wrong group number");
            }
        }
    }
}
