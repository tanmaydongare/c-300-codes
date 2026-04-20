using System;
using System.Linq;
namespace CSharpPrograms.Program132;

public class Program
{
    public static void Main()
    {
        // Program 132: LINQ Aggregate
        Console.WriteLine("Program 132 - LINQ Aggregate");
        int[] values = { 1, 2, 3, 4, 5, 6 };
        var evens = System.Linq.Enumerable.Where(values, x => x % 2 == 0);
        Console.WriteLine("LINQ result: " + string.Join(", ", evens));
    }
}
