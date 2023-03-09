using System;

namespace Classes;

public class Student
{
    public string Name { get; set; }

    public int StudentId { get; set; }

    public int NumberOfCredits { get; set; }

    public double Gpa { get; set; }

    public Student (string name, int studentId, int numberOfCredits, double gpa)
    {
    Name = name;
    StudentId = studentId;
    NumberOfCredits = numberOfCredits;
    Gpa = gpa;
        }
}
