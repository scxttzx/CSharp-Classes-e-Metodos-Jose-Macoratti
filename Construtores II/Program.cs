Console.WriteLine("## Construtores II ##");

Aluno aluno = new Aluno("Maria", 22, "feminino", "S");

//Aluno aluno2 = new Aluno(22, "feminino", "S");

// Operador (condição ? expressão1_se_true : expressão2_se_false)
Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

//Console.WriteLine("------------------------------------------------");

//Console.WriteLine(aluno2.Nome == null ? "null" : aluno2.Nome);
//Console.WriteLine(aluno2.Idade == 0 ? "zero" : aluno2.Idade);
//Console.WriteLine(aluno2.Sexo == null ? "null" : aluno2.Sexo);
//Console.WriteLine(aluno2.Aprovado == null ? "null" : aluno2.Aprovado);

Console.ReadKey();

public class Aluno
{
    public Aluno(string nome)
    {
        Nome = nome;
    }
    // Ou.. public Aluno (string nome) => Nome = nome;

    public Aluno(string nome, int idade, string sexo, string aprovado) : this (nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}