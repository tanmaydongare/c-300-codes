using System PalindromeString;
class Program
{
    static void Main()
    {
        string s = "madam";
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(s == new string(arr) ? "Palindrome" : "Not Palindrome");
    }
}