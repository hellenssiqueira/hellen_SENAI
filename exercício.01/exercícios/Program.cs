int A = 10;
int B = 20;

Console.WriteLine("valores iniciais:");
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);

A = A + B;
B = A - B;
A = A - B;

Console.WriteLine("\nvalores após a troca:");
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);