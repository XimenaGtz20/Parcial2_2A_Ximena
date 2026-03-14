using System;

class Program
{
    static void Main ()
    {
        int [] n = new int [5];

        for (int i = 0; i < 5; i ++ )
        {
            Console.Write("Ingresa un numero: ");
            n [i] = int.Parse(Console.ReadLine());

        }
        
        int nu = n [0];
        n [0] = n [4];
        n [4] = n [2];
        n [2] = nu;
        
        for (int i = 0; i < 5; i  ++)
        {
            Console.WriteLine (n [i] );
        }
    }
}
