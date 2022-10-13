class Result
{
    // Exercise 3: Complete the "compareTriplets" function to find their comparison points.
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var alice = 0;
        var bob = 0;
        var result = new List<int>();

        for (var i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
                alice++;
            else if (a[i] < b[i])
                 bob++;
        }

        result.Add(alice);
        result.Add(bob);

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        foreach(var i in result)
            Console.WriteLine(i);
    }
}