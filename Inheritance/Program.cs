using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE:  Create a class Animal
            // DONE: give this class 4 members that all Animals have in common


            //DONE:  Create a class Bird
            // DONE: give this class 4 members that are specific to Bird
            // DONE: Set this class to inherit from your Animal Class

            // DONE: Create a class Reptile
            // DONE: give this class 4 members that are specific to Reptile
            // DONE: Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.BirdFlies = true;
            myBird.Migrates = true;
            myBird.BeakLength = 3.5;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile();
            {
                myReptile.Habitat = "water and land";
                myReptile.HasScales = true;
                myReptile.IsVenomous = false;
                myReptile.IsCarnivor = false;
            }

            var myAnimals = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"{animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"");
            }

        }
    }
}
        
