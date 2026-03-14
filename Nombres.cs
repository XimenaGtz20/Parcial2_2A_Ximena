using System;

class Program
{
    static void Main ()

    {
        string [] nombres = {"Evangeline", "Mia", "Azul", "Dulce", "Miranda", "Andrew", "Sebastian", "Angel", "Liam", "Miguel"};
        string [] apellidos = { "Lopez", "Gutierrez", "Robles", "Herrera", "Sanchez", "Baez", "Garcia", "Cortes", "Martinez", "Castro"};

        Random rd = new Random (); 

        for (int i = 0; i < 5; i ++ ) 
        {
        int indiceNom = rd.Next(0, nombres.Length);
        int indiceApe = rd.Next(0, apellidos.Length);

        string nomAleatorio = nombres[indiceNom];
        string apeAleatorio = apellidos[indiceApe];

        Console.WriteLine($"{i + 1} {nomAleatorio} {apeAleatorio}");
        }
    }
}
