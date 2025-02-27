using System;

class Student
{
    public string Name;
    public int Age;

    public void Display()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Name = "John Doe";
        s1.Age = 20;
        s1.Display();
    }
}
