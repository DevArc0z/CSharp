using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pickaxePart2
{
    internal class car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public int YearBuilt { get; set; }

        public car(string model, string brand, int numberOfWheels, string color, int yearBuilt)
        {
            Model = model;
            Brand = brand;
            NumberOfWheels = numberOfWheels;
            Color = color;
            YearBuilt = yearBuilt;
        }

        public string GetDescription()
        {
            return $"{Brand} - {Model}: built in {YearBuilt}";
        }

        public string Drive()
        {
            return "Vroom Vroom!";
        }
        private bool HasValidNumberOfWheels()
        {
            return NumberOfWheels >= 3;
        }
    }
}
