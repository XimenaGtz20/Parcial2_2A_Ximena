using System;
using System.Linq;

namespace BuscaMinas;

public static class Program
{
    public static void Main()
    {
      // https://youtu.be/_6qlxq6YsWU
        Random rnd = new Random();
        int tamaño = 5; // tamaño inicial

        for (int nivel = 1; nivel <= 5; nivel++)
        {
            Console.WriteLine("\n-- NIVEL " + nivel + " --");

            // Aumentar tamaño aleatoriamente
            tamaño += rnd.Next(1, 6);

            // Tablero real (donde está la mina)
            char[] tablero = new char[tamaño];

            // Tablero visible para el usuario
            char[] visible = new char[tamaño];

            // Inicializar tableros
            for (int i = 0; i < tamaño; i++)
            {
                tablero[i] = '0';
                visible[i] = '_';
            }

            // Colocar mina aleatoria
            int mina = rnd.Next(0, tamaño);
            tablero[mina] = '*';

            bool encontrado = false;
            Console.WriteLine("¿Desea empezar el nivel? SI / NO");
            string opcion = Console.ReadLine().ToLower();
            if (opcion == "no")
            {
                break;
            }
            if (opcion == "si")
            {

                while (!encontrado)
                {
                    // Mostrar tablero visible
                    Console.Write("\nTablero: ");
                    for (int i = 0; i < tamaño; i++)
                    {
                        Console.Write(visible[i] + " ");
                    }

                    Console.Write("\nElige un índice (0 a " + (tamaño - 1) + "): ");
                    int indice = int.Parse(Console.ReadLine());

                    // Validar rango
                    if (indice < 0 || indice >= tamaño)
                    {
                        Console.WriteLine("Índice inválido");
                        continue;
                    }

                    // Si encuentra la mina
                    if (indice == mina)
                    {
                        visible[indice] = '*';
                        Console.WriteLine(" Encontraste la mina");
                        Console.Clear();
                        encontrado = true;
                    }

                    else
                    {
                        // Verificar si está cerca de la mina
                        if (indice == mina - 1 || indice == mina + 1)
                        {
                            visible[indice] = '1';
                        }
                        else
                        {
                            visible[indice] = '0';
                        }
                    }
                }

                Console.WriteLine("Pasaste al siguiente nivel...");
            }


        }
        Console.WriteLine("\n Fin del juego");
        Console.WriteLine("Gracias por jugar");
    }
}
