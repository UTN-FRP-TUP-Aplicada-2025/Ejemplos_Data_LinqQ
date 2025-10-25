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

var resultado =
    from r in lista
    orderby r.numero descending
    select r;

Console.WriteLine("Listado:");
foreach (var item in resultado)
{
    Console.WriteLine($"{item.numero,3} | {item.nombre,10}| {item.importe,6:f2}");
}
//  1 |   Agustina|  30.50
//  1 |   Agustina|  10.10
//  2 |    Cecilia|  90.10
//  2 |    Cecilia| 100.30
//  2 |    Cecilia| 200.00
//  3 |    Ricardo|   5.30
//  4 |    Celeste| 300.10
