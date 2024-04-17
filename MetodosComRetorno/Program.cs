Console.WriteLine("## Métodos com retorno ##\n");

Calculadora calculadora = new ();
var valor = calculadora.Somar(10, 10);
Console.WriteLine(valor);
Console.WriteLine(calculadora.Somar (10, 10));

Console.ReadKey();

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        var soma = n1 + n2;
        return soma;
    }
    public int Subtrair(int n1, int n2)
    {
        var subtracao = n1 - n2;
        return subtracao;
    }
    public int Multiplicar(int n1, int n2)
    {
        var multiplicacao = n1 * n2;
        return multiplicacao;
    }
    public int Dividir(int n1, int n2)
    {
        var divisao = n1 / n2;
        return divisao;
    }
}