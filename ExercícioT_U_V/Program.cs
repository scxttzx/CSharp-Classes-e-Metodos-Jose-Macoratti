Carro carro1 = new Carro();

Console.WriteLine("Informe o Modelo");
carro1.Modelo = Console.ReadLine();

Console.WriteLine("Informe a Montadora");
carro1.Montadora = Console.ReadLine();

Console.WriteLine("Informe a Marca");
carro1.Marca = Console.ReadLine();

Console.WriteLine("Informe a Potencia");
carro1.Potencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o Ano");
carro1.Ano = Convert.ToInt32(Console.ReadLine());

carro1.ExibirInfo();


Console.ReadKey();


// Exercício a
public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano = 0000;
    public int Potencia;

    public void ExibirInfo()
    {
        Console.WriteLine(Modelo, Montadora, marca, potencia, ano);
    }
}