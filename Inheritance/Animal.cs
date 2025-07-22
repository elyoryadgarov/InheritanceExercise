using System;
using System.Collections.Generic;

namespace Inheritance;

public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    
    // public List<string> AnimalDetails = new List<string>();
    //
    // public void AddDetails()
    // {
    //     AnimalDetails.Add(Name);
    // }

    public void AnimalDetails()
    {
        Console.WriteLine($"Name: {Name},  Color: {Color},  Gender: {Gender},  Age: {Age}");
    }

}