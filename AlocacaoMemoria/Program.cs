Console.WriteLine("## Alocação de Memória ##\n");

Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminimo";

Console.WriteLine($"Meu nome é {p1.nome}, tenho {p1.idade} anos e sou do sexo {p1.sexo}.");

Pessoa p2 = p1;

//Pessoa p2 = new Pessoa();
//p2.nome = "Manoel";
//p2.idade = 23;
//p2.sexo = "masculino";

Console.WriteLine($"Meu nome é {p2.nome}, tenho {p2.idade} anos e sou do sexo {p2.sexo}.");

Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}
