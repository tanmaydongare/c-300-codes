using System;
namespace CSharpPrograms.Program012;

public class Program
{
    public static void Main()
    {
        // Program 012: Fibonacci Series
        Console.WriteLine("Program 012 - Fibonacci Series");
        int a = 0, b = 1;
        Console.Write("Fibonacci: ");
        for (int i = 0; i < 8; i++) { Console.Write($"{a} "); int next = a + b; a = b; b = next; }
        Console.WriteLine();
    }
}
