using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade percentage: ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if(gradePercentage >=80)
        {
            letter = "B";
        }
        else if(gradePercentage >=70)
        {
            letter = "C";
        }
        else if(gradePercentage >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradePercentage >= 70)
        {
            Console.Write($"congratiolations you passed");
        }

        else
        {
            Console.Write($"sorry you failed");
        }
    }
}