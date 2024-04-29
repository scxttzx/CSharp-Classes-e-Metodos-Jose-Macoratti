
Cliente cliente = new("Gabriel", "gbzinho@gmail.com", 17);
cliente.ExibirInfo();


Console.ReadKey();

public struct Cliente
{
    public string Nome;
    public string Email;

    private int idade = 0;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (idade < 18)
            {
                idade = 18;
            }
            else 
            {
                idade = value;
            }
        }
    }
    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Olá {Nome}, {Idade} anos\nEmail é: {Email}");
    }
}