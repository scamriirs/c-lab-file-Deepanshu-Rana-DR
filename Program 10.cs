//10. Write a program to understand the working of predefined string functions.


using System;

class StringFunctions
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        
        Console.WriteLine("Compare: " + str1.CompareTo(str2));
        Console.WriteLine("Concat: " + string.Concat(str1, " ", str2));
        Console.WriteLine("Join: " + string.Join(", ", str1, str2));
        
    }
}