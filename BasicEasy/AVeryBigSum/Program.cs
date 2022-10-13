class Result
{
    // Exercise 4: Complete the "AVeryBigSum" function to calculate the sum of all elements in the list.
    public static long aVeryBigSum(List<long> ar)
    {
        long sum = 0;
        foreach(var i in ar)
            sum += i;

        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
        long result = Result.aVeryBigSum(ar);

        Console.WriteLine(result);
    }
}