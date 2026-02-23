using System SearchElement;
class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4};
        int key = 3;
        Console.WriteLine(Array.IndexOf(arr, key) >= 0 ? "Found" : "Not Found");
    }
}