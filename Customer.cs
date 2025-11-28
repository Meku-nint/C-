public class Customer
{   // static fields are shared among all instances of the class we only can access them directly inside static methods.
   // instance fields belong to each instance of the class and can be accessed through object references.
   // In the example below, we define instance fields customerId and customerName, and a method DisplayCustomerInfo to display their values.
   // static methods can only directly access static fields.
    static int customerId=0;
    static string customerName="smith";
    public static void DisplayCustomerInfo()
    {
        Console.WriteLine("Customer ID: " + customerId);
        Console.WriteLine("Customer Name: " + customerName);
    }
    public static void Main()
    {   
        Console.WriteLine("Customer Information:"); 
        Customer.DisplayCustomerInfo();
    }
}