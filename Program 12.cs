using System;

class Student
{
    public string Name;
    public int Age;

    // Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Alice", 22);
        s1.Display();
    }
}
