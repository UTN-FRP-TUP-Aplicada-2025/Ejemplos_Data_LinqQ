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
    where r.numero == 2
    select r;

Console.WriteLine("Listado:");
foreach (var item in resultado)
{
    Console.WriteLine($"{item.numero,3} | {item.nombre,10}| {item.importe,6:f2}");
}