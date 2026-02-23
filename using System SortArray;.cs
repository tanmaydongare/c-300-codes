using System SortArray;
class Program
{
    static void Main()
    {
        int[] arr = {5,2,9,1};
        Array.Sort(arr);
        foreach (int i in arr)
            Console.WriteLine(i);
    }
}