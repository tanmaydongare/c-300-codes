using System;
using System.Linq;
namespace CSharpPrograms.Program131;

public class Program
{
    public static void Main()
    {
        // Program 131: LINQ Join
        Console.WriteLine("Program 131 - LINQ Join");
        int[] values = { 1, 2, 3, 4, 5, 6 };
        var evens = System.Linq.Enumerable.Where(values, x => x % 2 == 0);
        Console.WriteLine("LINQ result: " + string.Join(", ", evens));
    }
}
