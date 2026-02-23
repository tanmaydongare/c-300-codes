using System GradeCalculation;
class Program
{
    static void Main()
    {
        int marks = Convert.ToInt32(Console.ReadLine());
        if (marks >= 90) Console.WriteLine("A");
        else if (marks >= 75) Console.WriteLine("B");
        else if (marks >= 50) Console.WriteLine("C");
        else Console.WriteLine("Fail");
    }
}