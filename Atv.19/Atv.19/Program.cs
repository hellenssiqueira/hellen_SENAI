Console.WriteLine("Quantos números você vai digitar? ");
int n = int.Parse(Console.ReadLine());

if (n < 3)
{
    Console.WriteLine("Erroo: é necessário digitar pelo menos 3 números!");
    return;
}

double soma = 0;
double maior = double.MinValue;
double menor = double.MaxValue;

for (int i = 1; i < n; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    double valor = double.Parse(Console.ReadLine());

    soma += valor;

    if (valor > maior)
        maior = valor;

    if (valor < menor)
        menor = valor;
}

double media = (soma - maior - menor) / (n - 2);

Console.WriteLine($"A média excluindo o menor ({menor}) e o maior ({maior}) é: {media}");
