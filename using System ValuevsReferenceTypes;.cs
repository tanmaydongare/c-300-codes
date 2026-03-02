using System  ValuevsReferenceTypes;
class Program
{
    static void Main()
    {
        int a=5;
        int b=a;
        b=10;
        Console.WriteLine(a);
    }
}