var lista = new List<dynamic>
{
  new { numero = 1, nombre = "Agustina", importe = 30.5 },
  new { numero = 2, nombre = "Cecilia", importe = 90.1 },
  new { numero = 1, nombre = "Agustina",importe = 10.1 },
  new { numero= 3, nombre = "Ricardo", importe = 5.3 },
  new { numero= 2, nombre = "Cecilia", importe = 100.3 },
  new { numero= 2, nombre = "Cecilia", importe = 200.0 },
  new { numero= 4, nombre = "Celeste", importe = 300.1 },
};

//agrupando por numero y persona
var resultado =
    from r in lista
    group r by (r.numero, r.nombre) into grupo
    orderby grupo.Key ascending
    select grupo;

Console.WriteLine("Listado:");
foreach (var grupo in resultado)
{
    Console.WriteLine($"{grupo.Key.numero,3} {grupo.Key.nombre,3} ({grupo.Count()})");
    foreach (var item in grupo)
    {
        Console.WriteLine($" {item.importe,16:f2}");
    }
}

//  1 Agustina(2)
//           30.50
//           10.10
//  2 Cecilia(3)
//           90.10
//          100.30
//          200.00
//  3 Ricardo(1)
//            5.30
//  4 Celeste(1)
//          300.10

