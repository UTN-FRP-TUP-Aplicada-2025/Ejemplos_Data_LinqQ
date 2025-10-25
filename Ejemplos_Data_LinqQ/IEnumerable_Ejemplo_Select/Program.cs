

var numeros =new List<int>{ 1, 2, 3, 4, 5 };

//query expression
var cuadrados = from n in numeros
                select n * n;

Console.WriteLine("Números originales:");
foreach (var numero in cuadrados)
{
    Console.WriteLine(numero);
}