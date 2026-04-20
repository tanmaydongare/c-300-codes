using System;
namespace CSharpPrograms.Program142;

public class Program
{
    public static void Main()
    {
        // Program 142: Async And Await
        Console.WriteLine("Program 142 - Async And Await");
        Console.WriteLine("Starting async demo...");
        System.Threading.Tasks.Task.Delay(200).Wait();
        Console.WriteLine("Completed async demo.");
    }
}
