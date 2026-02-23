using SystemValidateEmail;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string email="test@gmail.com";
        Console.WriteLine(Regex.IsMatch(email,@"^[^@\s]+@[^@\s]+\.[^@\s]+$"));
    }
}