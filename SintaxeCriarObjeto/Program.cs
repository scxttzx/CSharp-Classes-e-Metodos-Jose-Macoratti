Console.WriteLine("## Sintaxes para criar objetos ##\n");

Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminimo";

// também pode ser instanciada da seguinte maneira
var p2 = new Pessoa();

// Ou...
Pessoa p3 = new();

Console.WriteLine($"Meu nome é {p1.nome}, tenho {p1.idade} anos e sou do sexo {p1.sexo}.");

Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}
