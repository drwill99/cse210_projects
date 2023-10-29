using System;

class Program
{
    static void Main()
    {
       Console.WriteLine("Enter a numeric grade (between 0 and 100):");
        if (float.TryParse(Console.ReadLine(), out float studentGrade))
        {
            string letterGrade;

            if (studentGrade >= 90)
                letterGrade = "A";
            else if (studentGrade >= 80)
                letterGrade = "B";
            else if (studentGrade >= 70)
                letterGrade = "C";
            else if (studentGrade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            Console.WriteLine($"Letter grade for {studentGrade:F2} is {letterGrade}");
        }
    }
}