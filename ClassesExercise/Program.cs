using System;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2021;

            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
            
        }
    }
}
