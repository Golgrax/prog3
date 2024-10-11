using System;

class Program
{
    static void Main()
    {
        // Taking inputs for user details
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Your City: ");
        string city = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your pin: ");
        string pin = Console.ReadLine();

        // Displaying the information in the desired format
        Console.WriteLine("\n==========================================");
        Console.WriteLine("Your Complete Address:");
        Console.WriteLine("==========================================\n");

        Console.WriteLine($"Name - {name}");
        Console.WriteLine($"City - {city}");
        Console.WriteLine($"Age - {age}");
        Console.WriteLine($"Pin - {pin}");
    }
}
