class Result
{
     // Exercise 12: Complete the "countApplesAndOranges" function to determine the number of apples and oranges that land on Sam's house.
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int applesOnHouse = 0;
        int orangesOnHouse = 0;

        for (int i = 0; i < apples.Count; i++)
        {
            apples[i] = apples[i] + a;

            if (apples[i] >= s && (apples[i] <= t))
            {
                applesOnHouse++;
            }
        }

        for (int i = 0; i < oranges.Count; i++)
        {
            oranges[i] = oranges[i] + b;

            if (oranges[i] >= s && oranges[i] <= t)
            {
                orangesOnHouse++;
            }
        }

        Console.WriteLine(applesOnHouse);
        Console.WriteLine(orangesOnHouse);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}