using SystemRemoveSpecialCharacters;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string s="Hello@123";
        Console.WriteLine(Regex.Replace(s,"[^a-zA-Z0-9]",""));
    }
}