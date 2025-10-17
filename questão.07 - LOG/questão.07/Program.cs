Console.WriteLine("Digite o número inicial(start): ");
int start = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número final (end): ");
int end = int.Parse(Console.ReadLine());

if (start > end)
{
    int temp = start;
    start = end;
    end = temp;
}

for (int n = start; n < end; n++)
{
    Console.WriteLine($"Tabuada do {n}:");

    for (int i = 1; i < 10; i++)
    {
        int resultado = n * i;
        Console.WriteLine($"{n} x {i} = {resultado}");
    }
    Console.WriteLine();
}

