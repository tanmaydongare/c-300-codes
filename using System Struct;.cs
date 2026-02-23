using System Struct;
struct Student
{
    public int Id;
    public string Name;
}
class Program
{
    static void Main()
    {
        Student s;
        s.Id = 1;
        s.Name = "Ganesh";
        Console.WriteLine(s.Id + " " + s.Name);
    }
}