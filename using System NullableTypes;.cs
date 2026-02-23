using System NullableTypes;
class Program
{
    static void Main()
    {
        int? x = null;
        Console.WriteLine(x.HasValue ? x.Value.ToString() : "Null");
    }
}