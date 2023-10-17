using Exercise3;

// Create a instance of each class and set the fuel to max
var car = new Car("Mercedes")
{
    Fuel = Car.MaxFuel
};

var bus = new Bus("Volvo")
{
    Fuel = Bus.MaxFuel
};

var motorbike = new Motorbike("Yamaha")
{
    Fuel = Motorbike.MaxFuel
};

// Test drive each vehicle
TestDrive(car);
Console.WriteLine("----------------------------------");
TestDrive(motorbike);
Console.WriteLine("----------------------------------");
TestDrive(bus);
Console.WriteLine("----------------------------------");

// Test drive method, takes a IDriveable as parameter
static void TestDrive(IDriveable vehicle)
{
    Console.WriteLine($"{vehicle} test drive");
    vehicle.StartEngine();
    vehicle.Accelerate();
    Console.WriteLine($"{vehicle} speed {vehicle.Speed} km/h");
    vehicle.TurnLeft();
    vehicle.TurnRight();
    vehicle.Brake();
    vehicle.StopEngine();
    Console.WriteLine($"{vehicle} fuel left {vehicle.Fuel} liters");
}