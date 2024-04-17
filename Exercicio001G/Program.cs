Carro carro1 = new Carro("SUV", "Ford");
Console.Write($"Modelo: {carro1.Modelo}\nMontadora: {carro1.Montadora}\nMarca: {carro1.Marca}\nAno: {carro1.Ano}\nPotencia: {carro1.Potencia}\n");
carro1.Acelerar();

Console.ReadKey();


// Exercício a
public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }
    public Carro(string? marca, int ano, int potencia) 
    { 
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }

    public void Acelerar()
    {
        Console.WriteLine($"{Marca}: Acelerando...");
    }
}