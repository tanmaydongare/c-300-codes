using SystemStringBuilder;
using System.Text;
class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World");
        Console.WriteLine(sb.ToString());
    }
}