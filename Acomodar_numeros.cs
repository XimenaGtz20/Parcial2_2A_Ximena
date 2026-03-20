using System;

class Program
{
    static void Main()
    {
        int aux;

        Console.WriteLine("Ingresa 3 numeros: ");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        if (n1 < n2 )
        {
            aux = n2;
            n2 =  n1;
            n1 = aux;
        }
        if (n1 < n3)
        {
            aux = n3;
            n3 = n1;
            n1 = aux;
        }
        if (n2 < n3)
        {
            aux = n3;
            n3 = n2;
            n2 = aux;
        }

        Console.WriteLine("Numeros ordenados: " + n1 + "," + n2 + "," + n3);
    }

}
