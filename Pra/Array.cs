class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting");
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Vehicle();
        v.Start();  // Vehicle is starting

        Car c = new Car();
        c.Start();  // Car is starting
    }
}
