<Query Kind="Statements">
  <Namespace>System.Text.Json</Namespace>
  <Namespace>System.Text.Json.Nodes</Namespace>
  <RuntimeVersion>8.0</RuntimeVersion>
</Query>


var lista = JsonNode.Parse(@"
[
  { ""numero"": 1, ""nombre"": ""Agustina"", ""importe"": 30.5 },
  { ""numero"": 2, ""nombre"": ""Cecilia"", ""importe"": 90.1 }
]
")!.AsArray();

var query =
    from l in lista
    select l;

query.Dump();