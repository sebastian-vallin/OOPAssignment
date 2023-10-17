namespace Exercise2;

/// <summary>
/// A car
/// </summary>
public class Car : IDriveable
{
    public string Name { get; set; }
    
    public int Speed { get; set; }
    
    public int Fuel { get; set; }

    /// <summary>
    /// Create a new car
    /// </summary>
    /// <param name="name">The name of the car</param>
    public Car(string name)
    {
        Name = name;
    }
    
    public void StartEngine()
    {
        Console.WriteLine($"{this} started engine");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{this} stopped engine");
    }

    public void Accelerate()
    {
        Console.WriteLine($"{this} accelerated");
    }

    public void Brake()
    {
        Console.WriteLine($"{this} braked");
    }

    public void TurnLeft()
    {
        Console.WriteLine($"{this} turned left");
    }

    public void TurnRight()
    {
        Console.WriteLine($"{this} turned right");
    }

    public override string ToString()
    {
        return $"Car: {Name}";
    }
}