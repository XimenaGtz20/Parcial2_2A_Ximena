using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random rd = new Random();
        List<string> colores1 = new List<string>();
        List<string> colores2 = new List<string>();
        List<string> colores3 = new List<string>();

        int rango = 0, numero1 = 0, numero2 = 0, numero3 = 0;

        numero1 = rd.Next(0, 100);
        rango = numero1;

        numero2 = rd.Next(0, (100 - rango));
        rango += numero2;

        numero3 = (100 - rango);

        Console.WriteLine("🤍" + numero1);
        Console.WriteLine("💗" + numero2);
        Console.WriteLine("🖤" + numero3);

        for (int i = 0; i < numero1; i++)
        {
            colores1.Add("🤍");
        }
       for (int i = 0; i < numero2; i++)
        {
            colores2.Add("💗");
        }

        for (int i = 0; i < numero3; i++)
        {
            colores3.Add("🖤");
        }
        
        foreach (var c in colores1)
        {
            Console.Write(c);
        }
        Console.WriteLine();
        foreach (var v in colores2)
        {
            Console.Write(v);
        }
        Console.WriteLine();
        foreach (var m in colores3)
        {
            Console.Write(m);
        }
        Console.WriteLine();
    }
}
