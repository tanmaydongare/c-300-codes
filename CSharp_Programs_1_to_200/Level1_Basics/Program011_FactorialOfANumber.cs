using System;
namespace CSharpPrograms.Program011;

public class Program
{
    public static void Main()
    {
        // Program 011: Factorial Of A Number
        Console.WriteLine("Program 011 - Factorial Of A Number");
        int n = 5;
        long fact = 1;
        for (int i = 2; i <= n; i++) fact *= i;
        Console.WriteLine($"Factorial = {fact}");
    }
}
