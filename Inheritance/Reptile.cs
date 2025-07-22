using System;

namespace Inheritance;

public class Reptile : Animal
{
    public string TypeOfReptile { get; set; }
    public string BodyType { get; set; }
    public double Weight { get; set; }
    public string IsSwimming { get; set; }
    
    public void BirdDetails()
    {
        Console.WriteLine($"Type Of Reptile: {TypeOfReptile} BodyType: {BodyType} Weight: {Weight}  IsSwimming: {IsSwimming}");
    }
    
}