using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        public static string Habitat { get; private set; }
        public static bool CanGrowTail { get; private set; }
        public static bool IsColdBlooded { get; private set; }
        public static bool IsScaly { get; private set; }

        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal **DONE**
            // give this class 4 members that all Animals have in common **DONE**


            // Create a class Bird **DONE**
            // give this class 4 members that are specific to Bird **DONE**
            // Set this class to inherit from your Animal Class **DONE**

            // Create a class Reptile **DONE**
            // give this class 4 members that are specific to Reptile **DONE**
            // Set this class to inherit from your Animal Class **DONE**




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Owl = new Bird();
            
                Owl.FurColor = "Grey";
                Owl.CanFly = true;
                Owl.LaysEggs = true;
                Owl.BeakLength = 1.5;




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var lizard = new Reptile();
            {
                IsColdBlooded = true;
                IsScaly = true;
                Habitat = "swamp";
                CanGrowTail = true;
            };

            var myAnimals = new Animal[] { Owl, lizard };

            foreach (var Animal in myAnimals)
            {
                Console.WriteLine($"Alive:{Animal.IsAlive}");
                Console.WriteLine($"Age:{Animal.Age} years old");
                Console.WriteLine($"It has:{Animal.LegCount} legs");
                Console.WriteLine($"It is a:{Animal.LandSeaAir} type");
            }
        }
    }
}
