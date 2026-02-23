using System CountDigits;
class Program
{
    static void Main()
    {
        int n = 1234, count = 0;
        while (n > 0)
        {
            count++;
            n /= 10;
        }
        Console.WriteLine(count);
    }
}