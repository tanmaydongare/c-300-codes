using System SecondLargestElement;
class Program
{
    static void Main()
    {
        int[] arr={5,1,9,3};
        Array.Sort(arr);
        Console.WriteLine(arr[arr.Length-2]);
    }
}