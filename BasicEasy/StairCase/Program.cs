class Result
{
    // Exercise 7: Complete the "staircase" function below to draw a stairs.
    public static void staircase(int n)
    {
        int x = n - 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(" ");
            }

            x--;

            for (int r = n - 1; r > x; r--)
            {
                Console.Write("#");
            }

            Console.WriteLine("");
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}