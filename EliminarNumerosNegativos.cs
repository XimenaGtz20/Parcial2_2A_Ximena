using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        Random rd = new Random();

        for (int i = 0; i < 10; i++)
        {
            numeros.Add(rd.Next(-1000, 1000));
        }

        Console.WriteLine("Lista original:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }

        numeros.RemoveAll(n => n < 0);

        Console.WriteLine("\nSin negativos:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }

        List<int> positivos = numeros.Where(n => n > 0).ToList();

        Console.WriteLine("\nLista de positivos:");
        foreach (int n in positivos)
        {
            Console.WriteLine(n);
        }

        bool todos = positivos.All(n => n > 0);
        Console.WriteLine("\n¿Todos son positivos? " + todos);

        positivos.Sort();

        Console.WriteLine("\nLista final ordenada:");
        foreach (int n in positivos)
        {
            Console.WriteLine(n);
        }
    }
}
