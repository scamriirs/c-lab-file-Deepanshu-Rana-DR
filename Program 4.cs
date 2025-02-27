//4. Understanding Library Functions
//This program demonstrates some commonly used built-in library functions in C#.


using System;

class LibraryFunctions
{
    static void Main()
    {
        string text = "Hello, C#";
        Console.WriteLine("Upper Case: " + text.ToUpper());
        Console.WriteLine("Lower Case: " + text.ToLower());
        Console.WriteLine("Length: " + text.Length);

        double sqrtValue = Math.Sqrt(25);
        Console.WriteLine("Square Root of 25: " + sqrtValue);

        int maxValue = Math.Max(10, 20);
        Console.WriteLine("Max Value between 10 and 20: " + maxValue);
    }
}

