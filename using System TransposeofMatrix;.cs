using System TransposeofMatrix;
class Program
{
    static void Main()
    {
        int[,] a = { {1,2},{3,4} };
        for(int i=0;i<2;i++)
            for(int j=0;j<2;j++)
                Console.WriteLine(a[j,i]);
    }
}