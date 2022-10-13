class Result
{
     // Complete the "gradingStudents" function below to round off student grades.
    public static List<int> gradingStudents(List<int> grades)
    {
        var multiples = new List<int>();
        var lessThan38 = 38;

        foreach (var grade in grades)
        {
            multiples.Add(Convert.ToInt32((Math.Round((decimal)grade/5m) * 5)));
        }

        for (int i = 0; i < grades.Count; i++)
        {
            if ((multiples[i] - grades[i] < 3) && (multiples[i] - grades[i] > 0) && grades[i] >= lessThan38)
                grades[i] = multiples[i];
        }

        return grades;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine("The final grade results are:");

        foreach(var res in result)
            Console.WriteLine(res);
    }
}