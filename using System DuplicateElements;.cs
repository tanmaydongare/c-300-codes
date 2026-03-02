using System DuplicateElements;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] arr={1,2,2,3,3};
        var dup=arr.GroupBy(x=>x).Where(g=>g.Count()>1);
        foreach(var d in dup)
            Console.WriteLine(d.Key);
    }
}