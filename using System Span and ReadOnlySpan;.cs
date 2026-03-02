using System Span and ReadOnlySpan;
class Program
{
    static void Main()
    {
        int[] arr={1,2,3,4};
        Span<int> span=arr;
        Console.WriteLine(span[0]);
    }
}