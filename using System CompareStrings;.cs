using System CompareStrings;
class Program
{
    static void Main()
    {
        string a = "abc";
        string b = "ABC";
        Console.WriteLine(string.Equals(a,b,StringComparison.OrdinalIgnoreCase));
    }
}