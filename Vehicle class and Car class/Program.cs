using System;

namespace Vehicle_class_and_Car_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new Car("Chevrolet", "Niva", 90, 0.25, 50);
            theCar.Color = "Blue";
            theCar.Year = 2004;
            Console.WriteLine(theCar.Brand + " " + theCar.Model + " " + theCar.Year);

            theCar.Drive(25);
            Console.ReadLine();
        }
    }
}
