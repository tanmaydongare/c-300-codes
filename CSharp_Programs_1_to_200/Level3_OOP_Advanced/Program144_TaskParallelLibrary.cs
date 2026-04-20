using System;
namespace CSharpPrograms.Program144;

public class Program
{
    public static void Main()
    {
        // Program 144: Task Parallel Library
        Console.WriteLine("Program 144 - Task Parallel Library");
        Console.WriteLine("Starting async demo...");
        System.Threading.Tasks.Task.Delay(200).Wait();
        Console.WriteLine("Completed async demo.");
    }
}
