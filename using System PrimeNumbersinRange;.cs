using System PrimeNumbersinRange;
class Program
{
    static void Main()
    {
        for (int i = 2; i <= 20; i++)
        {
            bool prime = true;
            for (int j = 2; j <= i / 2; j++)
                if (i % j == 0) prime = false;
            if (prime) Console.Write(i + " ");
        }
    }
}