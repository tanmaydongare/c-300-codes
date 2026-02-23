using System LargestandSmallestinArray;
class Program
{
    static void Main()
    {
        int[] arr = {5,2,9,1};
        int min = arr[0], max = arr[0];
        foreach (int i in arr)
        {
            if (i < min) min = i;
            if (i > max) max = i;
        }
        Console.WriteLine("Min=" + min);
        Console.WriteLine("Max=" + max);
    }
}