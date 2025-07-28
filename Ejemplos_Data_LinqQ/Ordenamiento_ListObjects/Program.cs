
using Ordenamiento_ListObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ordenamiento_ListObjects;

class Program
{
    static void Main()
    {
        // Lista de personas de ejemplo
        List<Persona> personas = new List<Persona>
        {
            new Persona { Nombre = "Juan", DNI = 12345678, Edad = 30 },
            new Persona { Nombre = "Ana", DNI = 87654321, Edad = 25 },
            new Persona { Nombre = "Carlos", DNI = 45678901, Edad = 35 },
            new Persona { Nombre = "María", DNI = 23456789, Edad = 28 }
        };

        Console.WriteLine("Lista original:");
        foreach (var persona in personas)
        {
            Console.WriteLine(persona);
        }

        // MÉTODO 1: OrderBy con lambda (más común)
        //var personasOrdenadas1 = personas.OrderBy(p => p.DNI).ToList();

        //Console.WriteLine("\nOrdenado por DNI (ascendente) - Método 1:");
        //foreach (var persona in personasOrdenadas1)
        //{
        //    Console.WriteLine(persona);
        //}

        //#region MÉTODO 2: OrderByDescending para orden descendente
        //var personasOrdenadas2 = personas.OrderByDescending(p => p.DNI).ToList();

        //Console.WriteLine("\nOrdenado por DNI (descendente):");
        //foreach (var persona in personasOrdenadas2)
        //{
        //    Console.WriteLine(persona);
        //}
        //#endregion

        //// MÉTODO 3: Ordenar directamente la lista original (modifica la lista)
        //personas.Sort((p1, p2) => p1.DNI.CompareTo(p2.DNI));

        //Console.WriteLine("\nLista original después de Sort:");
        //foreach (var persona in personas)
        //{
        //    Console.WriteLine(persona);
        //}

        //// MÉTODO 4: Múltiples criterios de ordenamiento
        //var personasMultiOrden = personas
        //    .OrderBy(p => p.DNI)
        //    .ThenBy(p => p.Nombre)
        //    .ToList();

        //Console.WriteLine("\nOrdenado por DNI y luego por Nombre:");
        //foreach (var persona in personasMultiOrden)
        //{
        //    Console.WriteLine(persona);
        //}
    }
}