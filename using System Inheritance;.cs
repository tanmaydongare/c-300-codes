using System Inheritance;
class Parent { public void Show() => Console.WriteLine("Parent"); }
class Child : Parent { }
class Program
{
    static void Main() { new Child().Show(); }
}