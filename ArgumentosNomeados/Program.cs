Console.WriteLine("## Argumentos Nomeados ##\n");

Email email = new();

email.Enviar("jorginhomeemprestaadoze@mccarol.com.br", "Urgente", "Reunião de Orçamento");

// Argumentos nomeados
email.Enviar(titulo: "Reunião de despedida", destino: "jorginhomeemprestaadoze@mccarol.com.br", assunto: "Adeus música");


Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}