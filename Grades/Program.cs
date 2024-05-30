using System;
using System.Collections.Generic;

public enum Degree
{
    A,
    B,
    C,
    D,
    E
}

public class Grade
{
    public string Subject { get; set; }
    public Degree Degree { get; set; }

    public Grade(string subject, Degree degree)
    {
        Subject = subject;
        Degree = degree;
    }
}

public class Student
{
    private List<Grade> grades = new List<Grade>();

    public void AddGrade(Grade grade)
    {
        grades.Add(grade);
    }

    public List<Grade> GetAllGrades()
    {
        return grades;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.AddGrade(new Grade("Math", Degree.A));
        student.AddGrade(new Grade("Physics", Degree.B));
        student.AddGrade(new Grade("Chemistry", Degree.C));

        List<Grade> allGrades = student.GetAllGrades();
        Console.WriteLine("All Grades:");
        foreach (var grade in allGrades)
        {
            Console.WriteLine($"Subject: {grade.Subject}, Degree: {grade.Degree}");
        }
    }
}
