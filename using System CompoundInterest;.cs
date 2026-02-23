using System CompoundInterest;
class Program
{
    static void Main()
    {
        double p = 1000, r = 5, t = 2;
        double ci = p * Math.Pow((1 + r / 100), t) - p;
        Console.WriteLine(ci);
    }
}