class Result
{
    // Exercise 9: Complete the "birthdayCakeCandles" function to calculate how many candles are the tallest.
    public static int birthdayCakeCandles(List<int> candles)
    {
        candles.Sort();
        var maxSize = candles[candles.Count - 1];
        var nrOfMaxSizeCandles = 0;

        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] == maxSize)
            {
                nrOfMaxSizeCandles++;
            }
        }

        return nrOfMaxSizeCandles;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        Console.WriteLine(result);
    }
}