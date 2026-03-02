using System  MultidimensionalArray;
class Program
{
    static void Main()
    {
        int[,] arr={{1,2},{3,4}};
        foreach(int i in arr)
            Console.WriteLine(i);
    }
}