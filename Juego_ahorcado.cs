using System;

class Program
{
    static void Main()
    {
        string palabra;
        int n;

        Console.WriteLine("Jugador 1: ¿De cuántas letras es tu palabra?, incluya espacios si lleva");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Jugador 1: Ingrese la palabra: ");
        palabra = Console.ReadLine();

        char[] letras = palabra.Trim().ToCharArray();

        Console.Clear();

        string palabraMostrar = "";

        for (int i = 0; i < n; i++)
        {
            if (letras[i] == ' ')
            {
                palabraMostrar += " ";
            }
            else
            {
                palabraMostrar += "-";
            }
        }

        int fallosRestantes = 5;
        char letraActual;
        bool terminado = false;

        do
        {
            Console.WriteLine("Palabra oculta: {0}", palabraMostrar);
            Console.WriteLine("Fallos restantes: {0}", fallosRestantes);

            Console.WriteLine("Jugador 2: Introduzca una letra: ");
            letraActual = Convert.ToChar(Console.ReadLine());

            if (palabra.IndexOf(letraActual) == -1)
            {
                fallosRestantes--;
            }

            string siguienteMostrar = "";

            for (int i = 0; i < n; i++)
            {
                if (letraActual == letras[i])
                {
                    siguienteMostrar += letraActual;
                }
                else
                {
                    siguienteMostrar += palabraMostrar[i];
                }
            }

            palabraMostrar = siguienteMostrar;

            if (palabraMostrar.IndexOf("-") < 0)
            {
                Console.WriteLine("Felicidades, acertaste!, la palabra es: {0}", palabra);
                terminado = true;
            }

            if (fallosRestantes == 0)
            {
                Console.WriteLine("Lo siento, la palabra era: {0}", palabra);
                terminado = true;
            }

            Console.WriteLine();

        } while (!terminado);

        Console.ReadKey();
    }
}
