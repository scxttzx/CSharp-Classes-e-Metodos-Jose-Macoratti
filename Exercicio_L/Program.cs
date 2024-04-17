Potencia pot = new Potencia();
int x = 10;
Console.WriteLine($"Valor de x antes de incrementar: {x}");
Console.WriteLine($"Valor de x incrementado: {pot.AumentarPotencia(x)}");


Console.ReadKey();

public class Potencia
{
    public int AumentarPotencia(int potencia)
    {
        potencia +=  3;
        return potencia;
    }

}
