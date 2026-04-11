using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tareas = new List<string>();

        tareas.Add("Hacer tarea de algebra");
        tareas.Add("Proyecto programación");


        tareas.Insert(0, "ENTREGAR PRACTICA URGENTE");

        string buscar = "Proyecto programación";
        if (tareas.Contains(buscar))
        {
            Console.WriteLine("La tarea existe: " + buscar);
        }
        else
        {
            Console.WriteLine("La tarea no existe");
        }

        tareas.Remove("Hacer tarea de algebra");

        Console.WriteLine("\nLista de tareas:");
        foreach (string tarea in tareas)
        {
            Console.WriteLine("💗 " + tarea);
        }

        Console.WriteLine("\nTotal de tareas: " + tareas.Count);
    }
}
