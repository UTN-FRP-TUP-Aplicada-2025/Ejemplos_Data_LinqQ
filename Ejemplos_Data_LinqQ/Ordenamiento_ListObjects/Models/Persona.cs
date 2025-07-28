using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_ListObjects.Models;

public class Persona
{
    public string Nombre { get; set; }
    public int DNI { get; set; }
    public int Edad { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, DNI: {DNI}, Edad: {Edad}";
    }
}
