using System paramsKeyword;
class Program
{
    static int Sum(params int[] arr)
    {
        int s=0;
        foreach(int i in arr) s+=i;
        return s;
    }
    static void Main()
    {
        Console.WriteLine(Sum(1,2,3,4));
    }
}