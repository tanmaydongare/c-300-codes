using System outandref;
class Program
{
    static void Square(int x,out int result)
    {
        result=x*x;
    }
    static void Main()
    {
        int r;
        Square(5,out r);
        Console.WriteLine(r);
    }
}