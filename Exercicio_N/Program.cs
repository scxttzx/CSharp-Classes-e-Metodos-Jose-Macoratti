Potencia pot = new Potencia();
int x = 10;
Console.WriteLine($"Valor de x antes de incrementar: {x}");
//Console.WriteLine($"Valor de x incrementado(sem sobrecarga): {AumentarPotencia(x)}");
Console.WriteLine($"Valor de x incrementado(com sobrecarga): {pot.AumentarPotencia(ref x)}");


Console.ReadKey();

public class Potencia
{
    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }

}