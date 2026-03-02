using System MemoryManagementBasics
class Program
{
    static void Main()
    {
        GC.Collect();
        Console.WriteLine("Garbage Collection Invoked");
    }
}