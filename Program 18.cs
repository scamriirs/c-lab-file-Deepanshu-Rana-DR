using System;

class StudentInfo
{
    public void StudentRecord()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        string rollNo = Console.ReadLine();

        Console.Write("Enter Course: ");
        string course = Console.ReadLine();

        Console.WriteLine("\n--- Student Record ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Roll Number: {rollNo}");
        Console.WriteLine($"Course: {course}");
    }
}

delegate void Student(); // Delegate declaration

class Program
{
    static void Main()
    {
        StudentInfo s = new StudentInfo();
        Student studentDelegate = new Student(s.StudentRecord);
        studentDelegate(); // Calling method using delegate
    }
}
