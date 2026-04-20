using System;
namespace CSharpPrograms.Program074;

public class Program
{
    public static void Main()
    {
        // Program 074: Fibonacci Using Recursion
        Console.WriteLine("Program 074 - Fibonacci Using Recursion");
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"{Fib(i)} ");
        }
        Console.WriteLine();
    }

    private static int Fib(int n)
    {
        return n <= 1 ? n : Fib(n - 1) + Fib(n - 2);
    }

}
