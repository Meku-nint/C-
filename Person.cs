// implementation of constructor overloading in c#
using System;
class Person
{
    private string name;
    private int age;

    // default constructor
    public Person()
    {
        name = "Yordanos";
        age = 0;
    }

    // parameterized constructor
    public Person(string personName, int personAge)
    {
        name = personName;
        age = personAge;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    public static void Main()
    {
        // creating an object using default constructor
        Person person1 = new Person();
        person1.DisplayInfo();

        // creating an object using parameterized constructor
        Person person2 = new Person("Alice", 30);
        person2.DisplayInfo();
    }
}