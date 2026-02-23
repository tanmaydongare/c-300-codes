using System PassingArraytoMethod;
class Program
{
    static void Print(int[] arr)
    {
        foreach(int i in arr)
            Console.WriteLine(i);
    }
    static void Main()
    {
        int[] a={1,2,3};
        Print(a);
    }
}