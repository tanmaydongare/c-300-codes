using SystemCharacterFrequency;
using System.Linq;
class Program
{
    static void Main()
    {
        string s = "hello";
        foreach(var c in s.Distinct())
            Console.WriteLine(c + " : " + s.Count(x=>x==c));
    }
}