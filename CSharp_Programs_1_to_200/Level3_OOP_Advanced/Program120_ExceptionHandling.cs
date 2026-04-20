using System;
namespace CSharpPrograms.Program120;

public class Program
{
    public static void Main()
    {
        // Program 120: Exception Handling
        Console.WriteLine("Program 120 - Exception Handling");
        try
        {
            int x = 10;
            int y = 0;
            Console.WriteLine(x / y);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Handled: {ex.Message}");
        }
    }
}
