Console.WriteLine("## Tipos Anônimos ##");

var aluno = new
{
    Nome = "Maria",
    Idade = 43,
    Email = "jairo@email.com",
    Endereco = new { ID = 1, Cidade = "Santos", Pais = "Brasil" }
};

//aluno.Idade = 43; 
//Não pode pois a propriedade é de apenas leitura

Console.WriteLine(aluno.GetType().ToString());

Console.WriteLine(aluno.Nome + " " + aluno.Idade);
Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Endereco.Cidade);


var aluno1 = new[]
{
    new { Nome = "João", Idade = 43, Email = "jairo@email.com" }
    new { Nome = "Maria", Idade = 3, Email = "asd@email.com" }
    new { Nome = "José", Idade = 21, Email = "tt@email.com" }
   
};

Console.WriteLine(aluno1[0].Nome);

Console.ReadKey();
