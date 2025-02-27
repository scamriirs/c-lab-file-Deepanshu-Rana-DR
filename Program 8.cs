//8. Write a program to implement recursion.

using System;

class RecursionDemo
{
    static int Factorial(int n)
    {
        if(n == 0) return 1;
        return n * Factorial( n - 1);
    }
    static void Main()
    { Console.WriteLine("Factorial of 5: "+ Factorial(5));
    }
}