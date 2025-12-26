using System;

// get and set are accessors in C# used to define properties in a class
class Car
{
    private string model;  // private field
    private int year;      // private field

    // Property for model
    public string Model
    {
        set { model = value; }   // set accessor
        get { return model; }    // get accessor
    }

    // Property for year
    public int Year
    {
        set { year = value; }    // set accessor
        get { return year; }     // get accessor
    }

    public static void Main()
    {
        Car car = new Car();

        // Access private fields via properties
        car.Model = "Toyota";    // calls set
        car.Year = 2020;         // calls set

        Console.WriteLine("Car Model: " + car.Model);  // calls get
        Console.WriteLine("Car Year: " + car.Year);    // calls get
    }
}
