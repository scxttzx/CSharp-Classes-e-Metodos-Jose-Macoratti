using Exercicio9;

// Continuar

Console.WriteLine("## Tabela de cores disponíveis para o veículo ##\n");
Console.WriteLine($"{Cores.Branco} - {Convert.ToInt32(Cores.Branco)}");
Console.WriteLine($"{Cores.Vermelho} - {Convert.ToInt32(Cores.Vermelho)}");
Console.WriteLine($"{Cores.Preto} - {Convert.ToInt32(Cores.Preto)}");
Console.WriteLine($"{Cores.Cinza} - {Convert.ToInt32(Cores.Cinza)}");
Console.WriteLine($"{Cores.Prata} - {Convert.ToInt32(Cores.Prata)}");
Console.WriteLine($"{Cores.Azul} - {Convert.ToInt32(Cores.Azul)}\n");


Console.WriteLine("Informe o número de cor desejada (1 a 6)");
int cor = Convert.ToInt32(Console.ReadLine());



Carro c1 = new("Sedan", "Honda", "Civic", cor, 2024, 220);
c1.ExibirInfo();
public class Carro
{
    public int Cor;

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    private int ano = 0000;
    public int Ano
    {
        get { return ano; }
        set
        {
            if(ano > 2022) 
            {
                ano = 2022;
            }
            else if (ano < 2000)
            {
                ano = 2000;
            }
            else
            {
                ano = value;
            }
        }
    }
    public int Potencia;

    public Carro(string? modelo, string? montadora, string? marca, int cor, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Cor = cor;
        Ano = ano;
        Potencia = potencia;

    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Modelo: {Modelo}\nMontadora: {Montadora}\nMarca: {Marca}\nCor: {(Cores)Cor}\nAno: {Ano}\nPotencia: {Potencia}\n");
    }

}