Carro carro1 = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
Console.Write($"Modelo: {carro1.Modelo}\nMontadora: {carro1.Montadora}\nMarca: {carro1.Marca}\nAno: {carro1.Ano}\nPotencia: {carro1.Potencia}\n");
carro1.Acelerar();
var velo = carro1.VelocidadeMaxima(carro1.Potencia);
Console.WriteLine($"Velocidade máxima atingida: {velo}");

Console.ReadKey();


// Exercício a
public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }
    
    public double VelocidadeMaxima(int potencia)
    {
        double velocidadMaxima = potencia * 1.75;
        return velocidadMaxima;
    }

    public void Acelerar()
    {
        Console.WriteLine($"{Marca}: Acelerando...");
    }
}