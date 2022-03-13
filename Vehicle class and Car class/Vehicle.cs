using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_class_and_Car_class
{
    class Vehicle
    {      
        public string Color;
        public int Year;
        public Vehicle()
        {

        }
        public Vehicle(string Color)
        {
            this.Color = Color;
        }
        public Vehicle(string Color,int Year) : this(Color)
        {
            this.Year = Year;
        }
    }
}
