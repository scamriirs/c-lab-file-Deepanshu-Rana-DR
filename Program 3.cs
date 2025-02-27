//3. Understanding Control Statements
//This program demonstrates the use of control statements such as if-else, loops, and switch case.


using System;

class ControlStatements
{
    static void Main()
    {
        int number = 10;

        // If-Else statement
        if (number % 2 == 0)
            Console.WriteLine("Even Number");
        else
            Console.WriteLine("Odd Number");

        // For Loop
        for (int i = 1; i <= 5; i++)
            Console.WriteLine("For Loop Iteration: " + i);

        // While Loop
        int count = 0;
        while (count < 3)
        {
            Console.WriteLine("While Loop Iteration: " + count);
            count++;
        }

        // Switch Case
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }
    }
}

