
int x = 10;
Console.WriteLine($"Valor de x antes de incrementar: {x}");
Console.WriteLine($"Valor de x incrementado: {AumentarPotencia(x)}");


Console.ReadKey();
int AumentarPotencia(int potencia)
{
    potencia += 3;
    return potencia;
}
