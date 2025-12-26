// exception handling related code
using System;
class Handling
{
    static void Main()
    {
        int a=0;
        int b=5;
        try
        {
            int result =b/a;
            Console.WriteLine("Result: " + result);           
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine("Exception Message: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}