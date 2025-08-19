using System;
using System.Collections.Generic;


public class Course
{
    public string Name { get; set; }
    public string Code { get; set; }

    public Course(string name, string code)
    {
        Name = name;
        Code = code;
    }
}


public class Student
{
    public string StudentName { get; set; }
    private List<Course> courses;

    public Student(string studentName)
    {
        StudentName = studentName;
        courses = new List<Course>();
    }

    
    public void Enroll(Course course)
    {
        courses.Add(course);
        Console.WriteLine($"{StudentName} enrolled in {course.Name}");
    }

    
    public void ShowCourses()
    {
        Console.WriteLine($"\nCourses enrolled by {StudentName}:");
        foreach (var course in courses)
        {
            Console.WriteLine($"- {course.Name} ({course.Code})");
        }
    }
}

public class Program
{
    public static void Main()
    {
        
        Course c1 = new Course("Mathematics", "MATH101");
        Course c2 = new Course("Physics", "PHY101");
        Course c3 = new Course("Computer Science", "CSC440");

        
        Student student = new Student("Sabbir");

       
        student.Enroll(c1);
        student.Enroll(c2);
        student.Enroll(c3);

        
        student.ShowCourses();
    }
}

