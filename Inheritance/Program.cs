using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             *  
             * Creatively display the class member values 
             */

            Bird raven = new Bird()
            {
                Species = "Raven",
                Age = 3,
                Sound = "Cawww",
                IsWild = true,
                CanFly = true,
                WingSpanFt = 3 - 5,
                Migrate = false,
                FeatherColor = "Black"
            };

            Console.WriteLine($"Learned some random things about {raven.Species}s. I only knew that they had {raven.FeatherColor} feathers. I did not know they have a wingspan of {raven.WingSpanFt} feet!");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile snake = new Reptile
            {
                Species = "Snake",
                Age = 11,
                Sound = "Hisssss",
                IsWild = true,
                HasLegs = false,
                CanBeVenomous = true,
                IsColdBlooded = true,
                Habitat = "In the wild"
                
            };
            Console.WriteLine($"I am not big on reptiles but did some brief research on {snake.Species}s. They live {snake.Habitat}");

        }
    }
}
