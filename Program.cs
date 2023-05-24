Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("SC", "Santa Catarina");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("-------------------------");

estados.Remove("SC");
estados["MG"] = "Minas Gerais - Rei do Pão de Queijo";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("\n******** Verificando ********\n");

string chave = "MG";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}



Console.WriteLine("\n******** Verificando ********\n");

chave = "PE";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}


Console.WriteLine("\n******** Testando Acesso ********\n");

//Acesso a chave existente
Console.WriteLine(estados["SP"]);