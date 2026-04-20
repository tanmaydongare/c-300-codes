using System;
namespace CSharpPrograms.Program075;

public class Program
{
    public static void Main()
    {
        // Program 075: Factorial Using Recursion
        Console.WriteLine("Program 075 - Factorial Using Recursion");
        int n = 5;
        Console.WriteLine($"Factorial({n}) = {Factorial(n)}");
    }

    private static long Factorial(int n)
    {
        return n <= 1 ? 1 : n * Factorial(n - 1);
    }

}
