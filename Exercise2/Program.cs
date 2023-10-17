// See https://aka.ms/new-console-template for more information

using Exercise2;

// Create a instance of each class
var car = new Car("Mercedes");
var bus = new Bus("Volvo");
var motorbike = new Motorbike("Yamaha");

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
    vehicle.TurnLeft();
    vehicle.TurnRight();
    vehicle.Brake();
    vehicle.StopEngine();    
}
