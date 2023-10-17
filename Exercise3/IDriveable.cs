namespace Exercise3;

/// <summary>
/// Interface for a driveable vehicle.
/// </summary>
public interface IDriveable
{
    /// <summary>
    /// The name of the vehicle.
    /// </summary>
    string Name { get; set; }
    
    /// <summary>
    /// The speed of the vehicle.
    /// </summary>
    int Speed { get; set; }
    
    /// <summary>
    /// The fuel of the vehicle.
    /// </summary>
    int Fuel { get; set; }
    
    /// <summary>
    /// Starts the engine of the vehicle.
    /// </summary>
    void StartEngine();
    
    /// <summary>
    /// Stops the engine of the vehicle.
    /// </summary>
    void StopEngine();
    
    /// <summary>
    /// Accelerates the vehicle.
    /// </summary>
    void Accelerate();
    
    /// <summary>
    /// Brakes the vehicle.
    /// </summary>
    void Brake();
    
    /// <summary>
    /// Turns the vehicle left.
    /// </summary>
    void TurnLeft();
    
    /// <summary>
    /// Turns the vehicle right.
    /// </summary>
    void TurnRight();
}