var numeros = new List<int> { 1, 2, 3, 4, 5 };

var cuadrados = from n in numeros
                where n%2==0
                select n;

Console.WriteLine("Listado:");
foreach (var numero in cuadrados)
{
    Console.WriteLine(numero);
}