﻿string[] nomes = { "Ana", "Bruno", "Carlos", "Diana", "Eduardo" };
Console.Write("Digite um nome para buscar: ");
string nomeBusca = Console.ReadLine();
bool encontrado = false; 
                      
foreach (string nome in nomes)
{
    if (nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
    {
        encontrado = true;
        break; 
    }
}
if (encontrado)
    Console.WriteLine($"O nome {nomeBusca} foi encontrado no vetor.");
else
    Console.WriteLine($"O nome {nomeBusca} não está no vetor.");

