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
    group r by r.numero into grupo
    orderby grupo.Key ascending
    select new { numero=grupo.Key, cantidad=grupo.Count(), total=grupo.Sum(x=> (double)x.importe) } ;

Console.WriteLine("Listado:");
foreach (var item in resultado)
{
    Console.WriteLine($"{item.numero,3} | {item.cantidad,10}| {item.total,6:f2}");
}
// 1 | 2 | 40.60
// 2 | 3 | 390.40
// 3 | 1 | 5.30
// 4 | 1 | 300.10
