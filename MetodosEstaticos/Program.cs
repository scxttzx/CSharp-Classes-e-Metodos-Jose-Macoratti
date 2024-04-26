using System.ComponentModel.Design;

Console.WriteLine("## Métodos estáticos ##\n");

Calculadora calc = new Calculadora();

var soma = Calculadora.Somar(10, 10);
var subtrair = Calculadora.Subtrair(10, 10);
var multiplicar = Calculadora.Multiplicar(10, 10);
var dividir = Calculadora.Dividir(10, 10);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        var soma = n1 + n2;
        return soma;
    }
    public static int Subtrair(int n1, int n2)
    {
        var subtracao = n1 - n2;
        return subtracao;
    }
    public static int Multiplicar(int n1, int n2)
    {
        var multiplicacao = n1 * n2;
        return multiplicacao;
    }
    public static int Dividir(int n1, int n2)
    {
        var divisao = n1 / n2;
        return divisao;
    }
}