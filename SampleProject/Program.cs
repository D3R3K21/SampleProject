using System;
using System.Linq;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //whole number. How many times to loop through
            int stopAt = 3;
            //whole number. how many times it has looped through
            int numberOfIterations = 0;
            //true/false evaluation. is 1 equal to 2? false. value1 equal to value1? true
            bool continueThroughLoop = true;
            //characters, words, anything in quotes
            string currentCommand = "";
            //list of items. [] means array/list. the Object in front defines what type
            string[] exitCommands = new string[] { "q", "quit", "exit" };

            //do whats in the brackets in a loop that exits when the evaluation of the boolean value is false
            while (continueThroughLoop)
            {
                //setting the value inside the loop, so it checks every iteration. Console.Readline() reads user input from the console/terminal
                currentCommand = Console.ReadLine();
                //evaluates to true or false. do any of the strings in exitCommands equal the current command
                continueThroughLoop = exitCommands.All(cmd => cmd != currentCommand) || numberOfIterations++ == stopAt;
            }
            //dog can be animal
            Animal dog = new Dog();
            Console.Out.WriteLine($"dog height is {dog.Height.Inches} inches");
            //can "cast" animal to dog
            Dog sameDog = (Dog)dog;
            Console.Out.WriteLine($"sameDog height is {sameDog.Height.Inches} inches");
            //height is a nested "object" on the dog "object"
            dog.Height = new Height(38);
            Console.Out.WriteLine($"sameDog height is now {sameDog.Height.Inches} inches");
            Console.Out.WriteLine($"dog height is now {dog.Height.Inches} inches (same as sameDog)");
            sameDog.Breed = "pit bull";
            //can "cast" back to animal, but wont have "dog" properties anymore
            Animal sameAnimal = sameDog;
            //cannot access breed from "Animal" because the property is declared on "Dog"
            //sameAnimal.Breed; 
        }
    }
}
