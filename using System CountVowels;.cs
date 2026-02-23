using System CountVowels;
class Program
{
    static void Main()
    {
        string s = "Ganesh";
        int count = 0;
        foreach(char c in s.ToLower())
            if("aeiou".Contains(c)) count++;
        Console.WriteLine(count);
    }
}