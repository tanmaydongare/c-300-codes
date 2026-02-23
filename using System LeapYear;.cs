using System LeapYear;
class Program
{
    static void Main()
    {
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? "Leap Year" : "Not Leap Year");
    }
}