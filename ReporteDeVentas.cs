using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            List<int> ventas = new List<int> { 15000, 10000, 9000, 5100, 950, 1100, 11000 };

            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            Console.WriteLine("Ventas por día:");
            for (int i = 0; i < ventas.Count; i++)
            {
                Console.WriteLine($"{dias[i]}: {ventas[i]}");
            }

            Console.WriteLine($"\nSuma total: {ventas.Sum()}");

            Console.WriteLine($"Venta más alta: {ventas.Max()}");

            Console.WriteLine($"Venta más baja: {ventas.Min()}");

            var ventasOrdenadas = ventas.OrderByDescending(v => v);
            Console.WriteLine("Ventas de mayor a menor: " + string.Join(", ", ventasOrdenadas));

            bool superoMil = ventas.Any(v => v > 1000);
            Console.WriteLine($"¿Alguna venta superó los 1000?: {superoMil}");
        }
    }
