using System MissingNumber;
class Program
{
    static void Main()
    {
        int[] arr={1,2,4,5};
        int n=5;
        int total=n*(n+1)/2;
        int sum=0;
        foreach(int i in arr) sum+=i;
        Console.WriteLine(total-sum);
    }
}