int voto;
int candidatoA = 0, candidatoB = 0, candidatoC = 0, nulos = 0;

while (true)
{
    Console.WriteLine("\nDigite seu voto:");
    Console.WriteLine("1 - Candidato A");
    Console.WriteLine("2 - Candidato B");
    Console.WriteLine("3 - Candidato C");
    Console.WriteLine("4 - Voto Nulo");
    Console.WriteLine("0 - Encerrar votação");
    Console.Write("Opção: ");
    voto = int.Parse(Console.ReadLine());
    if (voto == 0) break; 
                        
    switch (voto)
    {
        case 1:
            candidatoA++;
            break;
        case 2:
            candidatoB++;
            break;
        case 3:
            candidatoC++;
            break;
        case 4:
            nulos++;
            break;
        default:
            Console.WriteLine("Voto inválido! Tente novamente.");
            break;
    }
}
