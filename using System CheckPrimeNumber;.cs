using System CheckPrimeNumber;
class Program
{
    static void Main()
    {
        int n = 17;
        bool prime = true;
        for (int i = 2; i <= n / 2; i++)
            if (n % i == 0) prime = false;
        Console.WriteLine(prime ? "Prime" : "Not Prime");
    }
}