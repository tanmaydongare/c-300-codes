using System LargestofThreeNumbers;
class Program
{
    static void Main()
    {
        int a = 10, b = 25, c = 15;
        int max = a > b ? (a > c ? a : c) : (b > c ? b : c);
        Console.WriteLine(max);
    }
}