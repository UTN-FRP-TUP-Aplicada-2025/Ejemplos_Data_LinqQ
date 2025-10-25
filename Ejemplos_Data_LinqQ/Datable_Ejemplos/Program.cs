using System.Data;

void MostrarDataTable(DataTable dt)
{
    foreach (DataRow row in dt.Rows)
    {
        Console.WriteLine($"Nombre: {row["Nombre"],25}, DNI: {row["DNI"],10}, Edad: {row["Edad"],10}");
    }
}

// Crear DataTable con estructura de Persona
DataTable dtPersonas = new DataTable("Personas");
dtPersonas.Columns.Add("Nombre", typeof(string));
dtPersonas.Columns.Add("DNI", typeof(int));
dtPersonas.Columns.Add("Edad", typeof(int));

// Agregar datos de ejemplo
dtPersonas.Rows.Add("Juan", 12345678, 30);
dtPersonas.Rows.Add("Ana", 87654321, 25);
dtPersonas.Rows.Add("Carlos", 45678901, 35);
dtPersonas.Rows.Add("María", 23456789, 28);

Console.WriteLine("DataTable original:");
MostrarDataTable(dtPersonas);

#region MÉTODO 1: Usando DataView (más eficiente para DataTable)
DataView dv = new DataView(dtPersonas);
dv.Sort = "DNI ASC";  // o "DNI DESC" para descendente
DataTable dtOrdenado1 = dv.ToTable();

Console.WriteLine("\nOrdenado por DNI (ascendente) - DataView:");
MostrarDataTable(dtOrdenado1);
#endregion

#region MÉTODO 2: Usando LINQ to DataTable (requiere System.Data.DataSetExtensions)
var filasOrdenadas = dtPersonas.AsEnumerable()
    .OrderBy(row => row.Field<int>("DNI"));
DataTable dtOrdenado2 = filasOrdenadas.CopyToDataTable();

Console.WriteLine("\nOrdenado por DNI (ascendente) - LINQ:");
MostrarDataTable(dtOrdenado2);
#endregion

#region MÉTODO 3: Ordenar descendente con LINQ
var filasDescendente = dtPersonas.AsEnumerable()
    .OrderByDescending(row => row.Field<int>("DNI"));
DataTable dtOrdenado3 = filasDescendente.CopyToDataTable();

Console.WriteLine("\nOrdenado por DNI (descendente) - LINQ:");
MostrarDataTable(dtOrdenado3);
#endregion

#region MÉTODO 4: Select con OrderBy usando DataTable.Select()
DataRow[] filasSeleccionadas = dtPersonas.Select("", "DNI ASC");
DataTable dtOrdenado4 = dtPersonas.Clone(); // Copia la estructura
foreach (DataRow row in filasSeleccionadas)
{
    dtOrdenado4.ImportRow(row);
}

Console.WriteLine("\nOrdenado por DNI (ascendente) - Select:");
MostrarDataTable(dtOrdenado4);
#endregion

#region MÉTODO 5: Múltiples criterios con LINQ
var multiOrden = dtPersonas.AsEnumerable()
    .OrderBy(row => row.Field<int>("DNI"))
    .ThenBy(row => row.Field<string>("Nombre"));
DataTable dtMultiOrden = multiOrden.CopyToDataTable();

Console.WriteLine("\nOrdenado por DNI y luego por Nombre:");
MostrarDataTable(dtMultiOrden);
#endregion

#region MÉTODO 6: Filtro y ordenamiento combinado
var filtradoYOrdenado = dtPersonas.AsEnumerable()
    .Where(row => row.Field<int>("Edad") > 25)
    .OrderBy(row => row.Field<int>("DNI"));

if (filtradoYOrdenado.Any())
{
    DataTable dtFiltrado = filtradoYOrdenado.CopyToDataTable();
    Console.WriteLine("\nFiltrado (Edad > 25) y ordenado por DNI:");
    MostrarDataTable(dtFiltrado);
}
#endregion