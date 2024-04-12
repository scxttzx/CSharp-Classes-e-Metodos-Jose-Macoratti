Console.WriteLine("## Métodos ##\n");


MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao();
//minhaClasse.ExibirDataAtual();

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem vindo");
        Console.WriteLine("Data do curso: 15/10/2022");
        ExibirDataAtual();
    }
    public void ExibirDataAtual()
    {
        Console.WriteLine("Data atual: " + DateTime.Now.ToShortDateString());
    }

// Métodos com uma epressão só, pode ser feito assim:
// public void ExibirDataAtual() Console.WriteLine("Data atual: " + DateTime.Now.ToShortDateString());
}