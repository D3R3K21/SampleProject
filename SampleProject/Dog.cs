using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject
{
    //Dog inherits from animal (dog is an animal)
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog()
        {
            this.NumberOfLegs = 4;
        }
    }
}
