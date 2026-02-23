using System SplitString;
class Program
{
    static void Main()
    {
        string s="CSharp is powerful";
        foreach(string w in s.Split(' '))
            Console.WriteLine(w);
    }
}