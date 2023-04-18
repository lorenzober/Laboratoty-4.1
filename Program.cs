using System;
using System.Linq;


public class Wheel
{
    public string Brand { get; set; }
    public int Size { get; set; }

    public Wheel(string brand, int size)
    {
        Brand = brand;
        Size = size;
    }

    public override string ToString()
        => $"Wheel Brand: {Brand}, Size: {Size}";

    // Equals and GetHashCode methods are not overridden, as the default implementation is sufficient in this case.
}

public class Engine
{
    public int HorsePower { get; set; }

    public Engine(int horsePower)
    {
        HorsePower = horsePower;
    }

    public override string ToString()
        => $"Engine HorsePower: {HorsePower}";

    // Equals and GetHashCode methods are not overridden, as the default implementation is sufficient in this case.
}

public class Car
{
    public string Make { get; set; }
    public Wheel[] Wheels { get; set; }
    public Engine Engine { get; set; }

    public Car(string make, Wheel[] wheels, Engine engine)
    {
        Make = make;
        Wheels = wheels;
        Engine = engine;
    }

    public void Drive()
    {
        Console.WriteLine("The car is driving.");
    }

    public void Refuel()
    {
        Console.WriteLine("The car is refueling.");
    }

    public void ReplaceWheel(int wheelIndex, Wheel newWheel)
    {
        Wheels[wheelIndex] = newWheel;
        Console.WriteLine($"Wheel {wheelIndex} has been replaced.");
    }

    public void PrintMake()
    {
        Console.WriteLine($"Car make: {Make}");
    }

    public override string ToString()
    => $"Car Make: {Make}, Engine: {Engine}, Wheels: [{string.Join(", ", Wheels.Select(wheel => wheel.ToString()))}]";

    // Equals and GetHashCode methods are not overridden, as the default implementation is sufficient in this case.
}

class Program
{
    static void Main(string[] args)
    {
        Wheel[] wheels = new Wheel[]
        {
            new Wheel("Pirelli", 18),
            new Wheel("Pirelli", 18),
            new Wheel("Pirelli", 18),
            new Wheel("Pirelli", 18)
        };
        Engine engine = new Engine(250);
        Car car = new Car("Toyota", wheels, engine);

        car.Drive();
        car.Refuel();
        car.ReplaceWheel(2, new Wheel("Bridgestone", 18));
        car.PrintMake();

        Console.WriteLine(car);
    }
}
