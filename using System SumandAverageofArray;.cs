using System SumandAverageofArray;
class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};
        int sum = 0;
        foreach (int i in arr) sum += i;
        Console.WriteLine("Sum=" + sum);
        Console.WriteLine("Avg=" + (sum / arr.Length));
    }
}