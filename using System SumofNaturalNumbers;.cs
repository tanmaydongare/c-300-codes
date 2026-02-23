using System SumofNaturalNumbers;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = n * (n + 1) / 2;
        Console.WriteLine(sum);
    }
}