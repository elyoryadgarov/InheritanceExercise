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
            var Chicken = new Bird();
            Chicken.CountryOfOrigin = "America";
            Chicken.Name = "Chick";
            Chicken.Age = 2;
            Chicken.Color = "Red";
            Chicken.Gender = "Male";
            Chicken.FoodType = "Seeds";
            Chicken.IsFlies = "Yes";
            Chicken.LifeStyle = "Day Time";

            static void AnimalDetails(Object obj)
            {
                foreach (var Item in obj.GetType().GetProperties())
                {
                    Console.WriteLine($"{Item.Name} : {Item.GetValue(obj)}");
                }
            }
            Console.WriteLine("Below Details of Chicken!");
            AnimalDetails(Chicken);

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            var Croc = new Reptile();
            Croc.TypeOfReptile = "Crocodile";
            Croc.Color = "Green";
            Croc.Gender = "Female";
            Croc.Age = 7;
            Croc.IsSwimming = "Yes";
            Croc.Name = "Crunch";
            Croc.Weight = 341.5;
            Croc.BodyType = "Distinctive";
            
            Console.WriteLine("\nBelow Details of Crocodile!");
            AnimalDetails(Croc);

        }
    }
}
