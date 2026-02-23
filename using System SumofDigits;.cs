using System SumofDigits;
class Program
{
    static void Main()
    {
        int n = 1234, sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
    }
}