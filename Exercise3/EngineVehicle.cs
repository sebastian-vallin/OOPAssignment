namespace Exercise3;

public abstract class EngineVehicle
{
    private int _speed;

    private int _fuel;

    public virtual int Speed
    {
        get => _speed;
        set => _speed = value;
    }

    public virtual int Fuel
    {
        get => _fuel;
        set => _fuel = value;
    }
}