using System JaggedArray;
class Program
{
    static void Main()
    {
        int[][] arr=new int[2][];
        arr[0]=new int[]{1,2};
        arr[1]=new int[]{3,4};
        foreach(var row in arr)
            foreach(var i in row)
                Console.WriteLine(i);
    }
}