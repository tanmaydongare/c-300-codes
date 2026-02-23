using System ReverseString;
class Program
{
    static void Main()
    {
        string s = "Hello";
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));
    }
}