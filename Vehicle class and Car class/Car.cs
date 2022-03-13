using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_class_and_Car_class
{
    class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(string Brand)
        {
            this.Brand = Brand;
        }
        public Car(string Brand, string Model) : this(Brand)
        {
            this.Model = Model;
        }
        public Car(string Brand, string Model, int FuelCapacity) : this(Brand, Model)
        {
            this.FuelCapacity = FuelCapacity;
        }
        public Car(string Brand, string Model, int FuelCapacity, double FuelFor1Km) : this(Brand, Model, FuelCapacity)
        {
            this.FuelFor1Km = FuelFor1Km;
        }
        public Car(string Brand, string Model, int FuelCapacity, double FuelFor1Km, double CurrentFuel) : this(Brand, Model, FuelCapacity, FuelFor1Km)
        {
            this.CurrentFuel = CurrentFuel;
        }

            public void ShowInfo()
        {
            Console.WriteLine($"Brand", "Model", FuelCapacity, FuelFor1Km, CurrentFuel, "Color", Year);
        }

        public void Drive(double DriveWay)
        {
            double result = CalculateForWay(DriveWay);
            
             double CalculateForWay(double DriveWay)
            {
                return CurrentFuel - (DriveWay * FuelFor1Km);
            }

            if (result > 0)
            {
                Console.WriteLine($"{DriveWay}km {Model} after {result}fuel will remain");
            }
            else
            {
                Console.WriteLine("You need fuel");
            }
        }
        
    }
}
