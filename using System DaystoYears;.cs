using System DaystoYears;
class Program
{
    static void Main()
    {
        int days = Convert.ToInt32(Console.ReadLine());
        int years = days / 365;
        days %= 365;
        int months = days / 30;
        days %= 30;
        Console.WriteLine(years + " Years " + months + " Months " + days + " Days");
    }
}