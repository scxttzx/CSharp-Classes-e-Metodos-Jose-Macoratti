using System.Security.Cryptography;
using System.Text.RegularExpressions;

Carro carro1 = new Carro();
carro1.Modelo = "Sedan";
carro1.Montadora = "Honda";
carro1.Marca = "Civic";
carro1.Ano = 2024;
carro1.Potencia = 220;

Console.WriteLine($"Modelo: {carro1.Modelo}\nMontadora: {carro1.Montadora}\nMarca: {carro1.Marca}\nAno: {carro1.Ano}\nPotencia: {carro1.Potencia}\nValor Ipva: {Carro.ObterValorIpva()}");

Console.ReadKey();


// Exercício a
public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;

    private int ano;
    public int Ano 
    {  
        get { return ano; }
        set 
        {
            switch (value) 
            {
                case < 2000:
                    ano = 2000;
                    break;
                case > 2022:
                    ano = 2022;
                    break;
                default:
                    ano = value;
                    break;
            }
        
        }
    }
    public int Potencia;
    public static double ValorIpva;

    public static double ObterValorIpva()
    {
        ValorIpva = 4;
        return ValorIpva;
    }
}
