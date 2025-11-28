class Constructor
{    int x=10;
    int y=20;
    public int Add()
    {
        return x + y;
    }
    // constructor in c# is a special method that is called when an object of a class is created.
    // it is used to initialize the object's fields and allocate resources.
    // constructors have the same name as the class and do not have a return type.
    // there are two types of constructors in c#: default constructor and parameterized constructor.
    public class Person
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

        // public static void Main()
        // {
        //     // creating an object using default constructor
        //     Person person1 = new Person();
        //     // creating an object using parameterized constructor
        //     Person person2 = new Person("Alice", 30);
        // }
    }
    public static void Main()
    {
        // creating an object using default constructor
        Person person1 = new Person();
        person1.DisplayInfo();
        // creating an object using parameterized constructor
        Person person2 = new Person("Alice", 30);
        person2.DisplayInfo();
        Constructor obj = new Constructor();
        int result = obj.Add();
        Console.WriteLine("The sum is: " + result);
    }
   
}