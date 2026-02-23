using System ReverseArray;
class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4};
        Array.Reverse(arr);
        foreach (int i in arr)
            Console.WriteLine(i);
    }
}