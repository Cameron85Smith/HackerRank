class Result
{
    // Exercise 5: Complete the "diagonalDifference" function to calculate the absolute value.
    public static int diagonalDifference(List<List<int>> arr)
    {
        var leftToRight = 0;
        var rightToLeft = 0;
        var j = 0;
        var x = arr.Count - 1;

         for (var i = 0; i < arr.Count; i++)
         {
            leftToRight += arr[i][j];
            rightToLeft += arr[i][x];
            j++;
            x--;
         }

        return Math.Abs(leftToRight - rightToLeft);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        System.Console.WriteLine(result);
    }
}