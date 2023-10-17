namespace Exercise3;

/// <summary>
/// A motorbike
/// </summary>
public class Motorbike : EngineVehicle, IDriveable
{
    /// <summary>
    /// The maximum speed of a motorbike
    /// </summary>
    public const int MaxSpeed = 160;

    /// <summary>
    /// The maximum fuel capacity of a motorbike
    /// </summary>
    public const int MaxFuel = 40;

    /// <summary>
    /// The fuel consumption of a motorbike
    /// </summary>
    public const int FuelConsumption = 5;
    
    public string Name { get; set; }

    public override int Speed
    {
        get => base.Speed;
        set => base.Speed = Math.Min(value, MaxSpeed);
    }

    public override int Fuel
    {
        get => base.Fuel;
        set => base.Fuel = Math.Min(value, MaxFuel);
    }

    /// <summary>
    /// Create a new motorbike
    /// </summary>
    /// <param name="name">The name of the motorbike</param>
    public Motorbike(string name)
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
        Speed += 10;
        Fuel -= FuelConsumption;
    }

    public void Brake()
    {
        Console.WriteLine($"{this} braked");
        Speed -= 10;
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
        return $"Motorbike: {Name}";
    }
}