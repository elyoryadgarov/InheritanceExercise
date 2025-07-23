using System;
using System.Collections.Generic;

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
             * Creatively display the class member values 
             */
            var chicken = new Bird();
            chicken.CountryOfOrigin = "America";
            chicken.Name = "Chick";
            chicken.Age = 2;
            chicken.Color = "Red";
            chicken.Gender = "Male";
            chicken.FoodType = "Seeds";
            chicken.IsFlies = "Yes";
            chicken.LifeStyle = "Day Time";

            static void AnimalDetails(Object obj)
            {
                foreach (var Item in obj.GetType().GetProperties())
                {
                    Console.WriteLine($"{Item.Name} : {Item.GetValue(obj)}");
                }
            }
            Console.WriteLine("Below Details of Chicken!");
            AnimalDetails(chicken);

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            var croc = new Reptile();
            croc.TypeOfReptile = "Crocodile";
            croc.Color = "Green";
            croc.Gender = "Female";
            croc.Age = 7;
            croc.IsSwimming = "Yes";
            croc.Name = "Crunch";
            croc.Weight = 341.5;
            croc.BodyType = "Distinctive";
            
            Console.WriteLine("\nBelow Details of Crocodile!");
            AnimalDetails(croc);

        }
    }
}
