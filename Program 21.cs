using System;
using System.Collections.Generic;

class Student
{
    public string RegistrationNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Class { get; set; }
    public string Email { get; set; }

    public void Display()
    {
        Console.WriteLine($"RegNo: {RegistrationNumber}, Name: {Name}, Age: {Age}, Class: {Class}, Email: {Email}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> studentDatabase = new List<Student>();

        // Add 10 student records
        studentDatabase.Add(new Student { RegistrationNumber = "REG001", Name = "Aditya Sharma", Age = 20, Class = "BCA 5th Sem", Email = "aditya@example.com" });
        studentDatabase.Add(new Student { RegistrationNumber = "REG002", Name = "Anjali Mehra", Age = 19, Class = "BCA 5th Sem", Email = "anjali@example.com" });
        studentDatabase.Add(new Student { RegistrationNumber = "REG003", Name = "Rahul Verma", Age = 21, Class = "BCA 5th Sem", Email = "rahul@example.com" });
        studentDatabase.Add(new Student { RegistrationNumber = "REG004", Name = "Priya Singh", Age = 20, Class = "BCA 5th Sem", Email = "priya@example.com" });
        studentDatabase.Add(new Student { RegistrationNumber = "REG005", Name = "Vikram Joshi", Age = 22, Class = "BCA 5th Sem", Email = "vikram@example.com" });
        studentDatabase.Add(new Student { RegistrationNumber = "REG006", Name = "Simran Kaur", Age = 19, Class = "BCA 5th Sem", Email = "simran@example.com" });
        studentDatabase.Add(new Student { RegistrationNumber = "REG007", Name = "Nikhil Gupta", Age = 20, Class = "BCA 5th Sem", Email = "nikhil@example.com" });
        studentDatabase.Add(new Student { RegistrationNumber = "REG008", Name = "Riya Sharma", Age = 21, Class = "BCA 5th Sem", Email = "riya@example.com" });
        studentDatabase.Add(new Student { RegistrationNumber = "REG009", Name = "Aman Kumar", Age = 22, Class = "BCA 5th Sem", Email = "aman@example.com" });
        studentDatabase.Add(new Student { RegistrationNumber = "REG010", Name = "Pooja Rani", Age = 20, Class = "BCA 5th Sem", Email = "pooja@example.com" });

        // Display all student records
        Console.WriteLine("Student Database:");
        foreach (var student in studentDatabase)
        {
            student.Display();
        }

        Console.ReadLine();
    }
}


💡 Output :
Student Database:
RegNo: REG001, Name: Aditya Sharma, Age: 20, Class: BCA 5th Sem, Email: aditya@example.com
RegNo: REG002, Name: Anjali Mehra, Age: 19, Class: BCA 5th Sem, Email: anjali@example.com
