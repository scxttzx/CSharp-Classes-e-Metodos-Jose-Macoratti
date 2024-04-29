using Exercicio9;

// Continuar

Console.WriteLine("Informe o número de cor desejada (1 a 6)");
int cor = Convert.ToInt32(Console.ReadLine());

Carro c1 = new("Sedan", "Honda", "Civic", cor, 2024, 220, 1200);

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Cor;

    private int ano = 0000;
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

    public Carro(string? modelo, string? montadora, string? marca, int cor, int ano, int potencia, double valoripva)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        Cor = cor;
        this.Ano = ano;
        this.Potencia = potencia;

    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Modelo: {Modelo}\nMontadora: {Montadora}\nMarca: {Marca}\nCor: {(Cores)Cor}\nAno: {Ano}\nPotencia: {Potencia}\n");
    }

}