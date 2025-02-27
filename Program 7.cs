//7. Demonstrate the use of passbyvalue and passbyReference by  writing a program.



using System;

class PassByDemo
{
    static void PassByValue(int x)
    {
        x += 10;
    }

    static void PassByReference(ref int x)
    {
        x += 10;
        
    }
    static void Main()
    {
        int num = 10;
        
         PassByValue(num);
         Console.WriteLine($"After PassByValue: {num}");
         
         PassByReference(ref num);
         Console.WriteLine($"After PassByReference: {num}");
         
    }
    
}

