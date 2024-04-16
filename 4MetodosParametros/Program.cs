Console.WriteLine("## Métodos - parâmetros ##");

Aluno aluno = new Aluno();
aluno.Consultar();

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        var aluno = new Aluno();

        Console.WriteLine("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo: ");
        aluno.Sexo = Console.ReadLine();

        Console.WriteLine("Aprovado (S)im ou (N)ão: ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new Curso();
        curso.Resultado(aluno);
    }
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"O aluno {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos");
        if (aluno.Aprovado != "S")
        {
            Console.WriteLine("foi reprovado");
        } else
        {
            Console.WriteLine("foi aprovado");
        }
    }
}