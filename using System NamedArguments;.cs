using System NamedArguments;
class Program
{
    static void Show(string name,int age)
    {
        Console.WriteLine(name+" "+age);
    }
    static void Main()
    {
        Show(age:20,name:"Ganesh");
    }
}