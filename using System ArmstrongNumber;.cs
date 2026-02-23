using System ArmstrongNumber;
class Program
{
    static void Main()
    {
        int n = 153, temp = n, sum = 0;
        while (n > 0)
        {
            int d = n % 10;
            sum += d * d * d;
            n /= 10;
        }
        Console.WriteLine(temp == sum ? "Armstrong" : "Not Armstrong");
    }
}