using System;

class Professor
{
    private static int professorCount = 0;  
    private int professorID;  

    public string profName;
    public string classTeach;

    private double _salary;  

    public double Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }

    

    
    public Professor()
    {
        professorCount++;
        professorID = professorCount;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Professor #{professorID}: {profName}. She/He teaches {classTeach} and has a salary of ${Salary}.");
    }
}

class Students
{
    public string studentName;
    public string classEnroll;

    private double _studentGrade;  

    public double StudentGrade
    {
        get { return _studentGrade; }
        set { _studentGrade = value; }
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student Name is {studentName}, Enrolled in {classEnroll}, Grade: {StudentGrade}.");
    }
    
// chatgpt , how to i make sure bob is specided as second professor , march 10 , 2025

class Program
{
    static void Main(string[] args)
    {
        
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.Salary = 9000;  
        p1.PrintInfo();

        Console.WriteLine();

        
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.Salary = 8000;  
        p2.PrintInfo();

        Console.WriteLine();

        
        Students s1 = new Students();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.StudentGrade = 90;  
        s1.PrintStudentInfo();

        Console.WriteLine();

        
        Students s2 = new Students();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.StudentGrade = 80;  
        s2.PrintStudentInfo();

        double salaryDifference = Math.Abs(p1.Salary - p2.Salary);
        Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: ${salaryDifference}\n");
        double totalStudentGrades = s1.StudentGrade + s2.StudentGrade;
        Console.WriteLine($"The total sum of all student grades is: {totalStudentGrades}");
}
    }
}
