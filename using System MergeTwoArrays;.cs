using System MergeTwoArrays;
class Program
{
    static void Main()
    {
        int[] a = {1,2};
        int[] b = {3,4};
        int[] c = new int[a.Length + b.Length];
        a.CopyTo(c,0);
        b.CopyTo(c,a.Length);
        foreach (int i in c)
            Console.WriteLine(i);
    }
}