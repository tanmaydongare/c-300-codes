using System;
namespace CSharpPrograms.Program123;

public class Program
{
    public static void Main()
    {
        // Program 123: Throwing Exceptions
        Console.WriteLine("Program 123 - Throwing Exceptions");
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
