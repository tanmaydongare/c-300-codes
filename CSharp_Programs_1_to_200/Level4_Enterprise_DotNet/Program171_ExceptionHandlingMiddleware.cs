using System;
namespace CSharpPrograms.Program171;

public class Program
{
    public static void Main()
    {
        // Program 171: Exception Handling Middleware
        Console.WriteLine("Program 171 - Exception Handling Middleware");
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
