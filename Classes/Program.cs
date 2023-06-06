using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Cars();
           
                car.Make = "Dodge";
                car.Model = "Ram";
                car.Year = 1998;

            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");

        }
    }
}
