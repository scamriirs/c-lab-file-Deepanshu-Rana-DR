//6. Write a program to store 10 elements in an array  and display the array elements in incresing order.

using System;

class ArraySorting
{
    static void Main()
    {
        int[] arr = { 5,2,9,1,3};
        Array.Sort(arr);
        Console.WriteLine("Sorted Array: "+ string.Join(", ", arr));
    }
}