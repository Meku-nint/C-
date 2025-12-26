// generics is the way you write reusable code components that can work with any data type.
using System;
class Template<T>
{
    private T data;

    public void SetData(T value)
    {
        data = value;
    }
    public T GetData()
    {
        return data;
    }
    public static void Main()
    {
        // Creating an instance of Template for int
        Template<int> intTemplate = new Template<int>();
        intTemplate.SetData(100);
        Console.WriteLine("Integer Data: " + intTemplate.GetData());

        // Creating an instance of Template for string
        Template<string> stringTemplate = new Template<string>();
        stringTemplate.SetData("Hello Generics");
        Console.WriteLine("String Data: " + stringTemplate.GetData());
    }
}