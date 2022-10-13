class Result
{
    // Exercise 2: Complete the "simpleArraySum" function to calculate the sum of the elements in the list.
    public static int simpleArraySum(List<int> ar)
    {
        var sum = 0;

        foreach (int value in ar)
        {
            sum += value;
        }

        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter a list of numbers separated by a space.");
        List<int> ar =  Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);

        Console.WriteLine(result);
    }
}