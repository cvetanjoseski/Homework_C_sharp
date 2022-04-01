using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Homework3
    {
        static void Main(string[] args)
        {
            List<Driver> Drivers = new List<Driver>()
            {
                new Driver ("Cvetan",10),
                new Driver ("Marko",9),
                new Driver ("Stefan",10),
                new Driver ("Bojan",10)
            };

            List<Car> Car = new List<Car>()
            {
                new Car("Hyundai",240,Drivers[1]),
                new Car("Mazda",240,Drivers[0]),
                new Car("Ferrari",300,Drivers[3]),
                new Car("Porsche",280,Drivers[2])
            };
            
            do
            {
                EliminateDriverAndRace(Drivers, Car);
                Console.WriteLine("If you want to make another race enter? Y/N");
            }
            while (Console.ReadLine().ToLower() == "y");

        }
        public static void RaceCars(Car carOne, Car carTwo,Driver driverOne,Driver driverTwo)
        {
            carOne.Driver = driverOne;
            carTwo.Driver = driverTwo;
            int carOneSpeed = carOne.CalculateSpeed();
            int carTwoSpeed = carTwo.CalculateSpeed();
            if (carOneSpeed<carTwoSpeed)
            {
                Console.WriteLine($"Winner of the race is car number two with: \n {carTwo.Model}, \n driver {carTwo.Driver.Name} and \n speed {carTwo.CalculateSpeed()}");
            }
            else if (carOneSpeed > carTwoSpeed)
            {
                Console.WriteLine($"Winner of the race is car number one with: \n {carOne.Model}, \n driver {carOne.Driver.Name} and \n speed {carOne.CalculateSpeed()}");
            }
            else
            {
                Console.WriteLine("We dont have winner Today");
            }
            
        }
        public static void EliminateDriverAndRace(List<Driver> Drivers, List<Car> Car)
        {
            Console.WriteLine("Choose your driver");
            foreach (Driver driver in Drivers)
            {
                Console.WriteLine($"No.{Drivers.IndexOf(driver)} {driver.Name}");
            }
            string driverOneString = (Console.ReadLine());
            bool isDriverOneOk = int.TryParse(driverOneString, out int driverOne);
            if (!isDriverOneOk)
            {
                Console.WriteLine("You entered wrong number, please enter again");
                driverOneString = (Console.ReadLine());
                driverOne = int.Parse(driverOneString);
            }

            Console.WriteLine("Choose your car");
            foreach (Car choosenCar in Car)
            {
                Console.WriteLine($"No.{Car.IndexOf(choosenCar)} {choosenCar.Model}");
            }
            string choosenCarOneString = Console.ReadLine();
            bool ischoosenCarOneOk = int.TryParse(choosenCarOneString, out int choosenCarOne);
            if (!ischoosenCarOneOk)
            {
                Console.WriteLine("You entered wrong number, please enter again");
                choosenCarOneString = Console.ReadLine();
                choosenCarOne = int.Parse(choosenCarOneString);
            }
            Console.WriteLine("Choose your second driver");
            foreach (Driver driver in Drivers)
            {
                if (Drivers.IndexOf(driver) == driverOne)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"No.{Drivers.IndexOf(driver)} {driver.Name}");
                }

            }
            string driverTwoString = Console.ReadLine();
            bool driverTwoOk = int.TryParse(driverTwoString, out int driverTwo);
            if (!driverTwoOk || (driverTwo == driverOne))
            {
                Console.WriteLine("You entered wrong number, please enter again");
                driverTwoString = Console.ReadLine();
                driverTwo = int.Parse(driverTwoString);
            }
            Console.WriteLine("Choose car for driver two");
            foreach (Car choosenCar in Car)
            {
                if (Car.IndexOf(choosenCar) == choosenCarOne)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"No.{Car.IndexOf(choosenCar)} {choosenCar.Model}");
                }

            }
            string choosenCarTwoString = Console.ReadLine();
            bool choosenCarTwoOk = int.TryParse(choosenCarTwoString, out int choosenCarTwo);
            if (!choosenCarTwoOk||(choosenCarTwo==choosenCarOne))
            {
                Console.WriteLine("You entered wrong number, please enter again");
                choosenCarTwoString = Console.ReadLine();
                choosenCarTwo = int.Parse(choosenCarTwoString);
            }
            RaceCars(Car[choosenCarOne], Car[choosenCarTwo], Drivers[driverOne], Drivers[driverTwo]);
        }
    }
}
