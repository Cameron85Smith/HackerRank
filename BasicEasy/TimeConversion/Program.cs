class Result
{
    // Exercise 10: Complete the "timeConversion" function by converting the string to a military (24-hour) time.
    public static string timeConversion(string s)
    {
        var time = DateTime.Parse(s);

        return time.ToString("HH:mm:ss");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        System.Console.WriteLine(result);
    }
}