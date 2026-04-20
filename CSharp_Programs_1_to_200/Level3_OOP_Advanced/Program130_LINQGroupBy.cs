using System;
using System.Linq;
namespace CSharpPrograms.Program130;

public class Program
{
    public static void Main()
    {
        // Program 130: LINQ GroupBy
        Console.WriteLine("Program 130 - LINQ GroupBy");
        int[] values = { 1, 2, 3, 4, 5, 6 };
        var evens = System.Linq.Enumerable.Where(values, x => x % 2 == 0);
        Console.WriteLine("LINQ result: " + string.Join(", ", evens));
    }
}
