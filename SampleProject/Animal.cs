using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject
{
    public class Animal
    {
        //public attributes (properties) an animal has
        public string Type { get; set; }
        public int Age { get; set; }
        public Height Height { get; set; }
        public int NumberOfLegs { get; set; }

        public Animal()
        {
            Height = new Height(0);
        }
    }

    public class Height
    {
        /// <summary>
        /// private property, cannot be set or accessed outside of this class
        /// constant value cannot be changed
        /// </summary>
        private const double CentimeterConversion = .39370;
        private const double FeetConversion = 12.0;
        //whole number
        public int Inches { get; protected set; }
        //decimal number
        public double Feet => Inches / FeetConversion;

        public double Centimeters => Inches / CentimeterConversion;
        //constructor method gets called once when the object is created
        public Height(int inches)
        {
            //value passed in when the object was created
            Inches = inches;
        }
    }
}
