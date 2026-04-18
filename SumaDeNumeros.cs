using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 0;
        for (int i = 0; i <= 100; i++)
        {
            int a = m;
            m += i;
            
             Console.WriteLine( $"{a} + {i} = {m}" );
        }
       
        Console.WriteLine(m);
    }
}
