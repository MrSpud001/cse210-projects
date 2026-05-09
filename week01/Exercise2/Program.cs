using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("Input grade as a percent");

        string grade = Console.ReadLine();
        int grade_as_num = int.Parse(grade);

        string final_grade;

        if (grade_as_num >= 90)
        {
            final_grade = "A";
        }
        else if (grade_as_num >= 80)
        {
            final_grade = "B";
        }
        else if (grade_as_num >= 70)
        {
            final_grade = "C";
        }
        else if (grade_as_num >= 60)
        {
            final_grade = "D";
        }
        else
        {
            final_grade = "F";
        }
        

        Console.WriteLine($"Final grade: {final_grade}");
    }
}