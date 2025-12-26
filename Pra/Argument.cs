// argument exception class
using System;
class Argument
{
    static void Main()
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            // Attempting to access an invalid index
            Console.WriteLine(numbers[5]);
            throw new ArgumentException("Index is out of range.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Argument Exception caught: " + ex.Message);
        }
       
    }
}