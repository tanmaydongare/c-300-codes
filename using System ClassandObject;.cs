using System ClassandObject;
class Student
{
    public string Name;
    public void Show() => Console.WriteLine(Name);
}
class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Tanmay";
        s.Show();
    }
}