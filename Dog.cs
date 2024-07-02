using System;
using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Petshop
{
    public class Dog
    {
        public double Weight { get; set; }
        public string Fur { get; set; }
        public double ExtraValue { get; set; } = 0; 

        public Dog()
        {
        }

        public Dog(double weight, string fur)
        {
            Weight = weight;
            Fur = fur;
        }

        public Dog(double weight, string fur, double extraValue) : this(weight, fur)
        {
            ExtraValue = extraValue;
        }

        public double Calculate()
        {
            double baseValue = 0;
            double multiplier;
            double finalValue;

            if (Weight < 3)
            {
                baseValue = 40.00;
            }
            else if (Weight < 10)
            {
                baseValue = 50.00;
            }
            else if (Weight >= 10 && Weight < 30)
            {
                baseValue = 60.00;
            }
            else
            {
                baseValue = 70.00;
            }

            if (Fur == "s" || Fur == "S")
            {
                multiplier = 1.0;
            }
            else if (Fur == "m" || Fur == "M")
            {
                multiplier = 1.5;
            }
            else
            {
                multiplier = 2.0;
            }

            finalValue = baseValue * multiplier + ExtraValue;

            return finalValue;
        }
    }
}
