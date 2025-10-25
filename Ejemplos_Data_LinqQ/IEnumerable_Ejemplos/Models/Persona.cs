using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_IEnumerable.Models;

public class Persona
{
    public string Nombre { get; set; }
    public int DNI { get; set; }
    public int Edad { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Nombre,25}, DNI: {DNI,10}, Edad: {Edad,10}";
    }
}
