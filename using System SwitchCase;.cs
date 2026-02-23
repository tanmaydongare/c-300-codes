using System SwitchCase;
class Program
{
    static void Main()
    {
        int day = 2;
        switch (day)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            default: Console.WriteLine("Invalid"); break;
        }
    }
}