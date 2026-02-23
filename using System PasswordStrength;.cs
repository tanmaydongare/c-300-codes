using System PasswordStrength;
class Program
{
    static void Main()
    {
        string pwd="TANMAY@123";
        bool strong=pwd.Length>=8;
        Console.WriteLine(strong);
    }
}