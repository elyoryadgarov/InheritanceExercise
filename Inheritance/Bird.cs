using System;

namespace Inheritance;

public class Bird : Animal
{
  
    public string CountryOfOrigin { get; set; }
    public string LifeStyle { get; set; }
    public string FoodType { get; set; }
    public string IsFlies { get; set; }
    
    public void BirdDetails()
    {
        Console.WriteLine($"CountryOfOrigin: {CountryOfOrigin},  LifeStyle: {LifeStyle}, FoodType: {FoodType}");
    }
    
}