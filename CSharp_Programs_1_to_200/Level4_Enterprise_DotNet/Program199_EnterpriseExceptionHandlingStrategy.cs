using System;
namespace CSharpPrograms.Program199;

public class Program
{
    public static void Main()
    {
        // Program 199: Enterprise Exception Handling Strategy
        Console.WriteLine("Program 199 - Enterprise Exception Handling Strategy");
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
