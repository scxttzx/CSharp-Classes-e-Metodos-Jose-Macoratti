Console.WriteLine("## Parâmetros Ocionais ##");


Console.WriteLine("Informe o destindo: ");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo: ");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto: ");
var assunto = Console.ReadLine();

Email email = new Email();

email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

// Não posso fazer
//email.Enviar(destino, , assunto); // causa um erro


Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}