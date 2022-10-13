class Result
{
    // Exercise 6: Complete the "plusMinus" function to calculate the ratio of positives, negatives, and zeroes.
    public static void plusMinus(List<int> arr)
    {
        var positives = 0m;
        var negatives = 0m;
        var zeroes = 0m;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
                positives++;
            if (arr[i] < 0)
                negatives++;
            else if (arr[i] == 0)
                zeroes++;
        }

        Console.WriteLine(decimal.Round(positives / arr.Count, 6));
        Console.WriteLine(decimal.Round(negatives / arr.Count, 6));
        Console.WriteLine(decimal.Round(zeroes / arr.Count, 6));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}