class Result
{
    // Exercise 13: Complete the "kangaroo" function to determine whether the two kangaroos will ever be in the same location.
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        var kangaroo1 = x1 + v1;
        var kangaroo2 = x2 + v2;
        var answer = "NO";

        for(int i = 0; i < 10000; i++)
        {
            if (kangaroo1 == kangaroo2)
            {
                return "YES";
            }

            kangaroo1 += v1;
            kangaroo2 += v2;
        }

        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
    }
}