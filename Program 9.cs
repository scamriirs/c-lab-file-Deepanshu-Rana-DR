//9. Write prograams to implement one dimentional and two dimentional array.


using System;

class ArrayDemo
{
    static void Main()
    {
        int[] arr1D = {1,2,3,4,5};
        Console.WriteLine("1D Array: "+ string.Join(", ", arr1D));
        
         int[,] arr2D = {{1,2},{3,4}};
        Console.WriteLine("2D Array: "+ arr2D[0,0]+ " "+arr2D[0,1]);
    }
}
