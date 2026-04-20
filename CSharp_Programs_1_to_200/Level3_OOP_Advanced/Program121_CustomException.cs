using System;
namespace CSharpPrograms.Program121;

public class Program
{
    public static void Main()
    {
        // Program 121: Custom Exception
        Console.WriteLine("Program 121 - Custom Exception");
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
