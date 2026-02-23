using SystemRemoveDuplicates;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] arr = {1,2,2,3,3};
        var result = arr.Distinct();
        foreach (int i in result)
            Console.WriteLine(i);
    }
}