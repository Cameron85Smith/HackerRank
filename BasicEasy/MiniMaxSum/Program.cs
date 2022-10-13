class Result
{
    // Exercise 8: Complete the "miniMaxSum" function by finding the minimum and maximum
    // values that can be calculated by summing exactly four of the five integers.
    public static void miniMaxSum(List<int> arr)
    {
        long min = 0;
        long max = 0;

        arr.Sort();

        for (int i = 0; i < arr.Count - 1; i++)
            min += arr[i];

        for (int i = arr.Count - 1; i > 0; i--)
            max += arr[i];

        Console.WriteLine(min + " " + max);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}