using System ReverseaNumber;
class Program
{
    static void Main()
    {
        int n = 1234, rev = 0;
        while (n > 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        Console.WriteLine(rev);
    }
}