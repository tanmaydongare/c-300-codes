using System OptionalParameters;
class Program
{
    static void Display(string name="Guest")
    {
        Console.WriteLine(name);
    }
    static void Main()
    {
        Display();
        Display("Ganesh");
    }
}