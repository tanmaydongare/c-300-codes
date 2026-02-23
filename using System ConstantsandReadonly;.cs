using System ConstantsandReadonly;
class Program
{
    const double PI = 3.14;
    readonly int x = 10;
    static void Main()
    {
        Program p = new Program();
        Console.WriteLine(PI);
        Console.WriteLine(p.x);
    }
}