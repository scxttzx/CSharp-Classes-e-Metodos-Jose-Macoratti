﻿Console.WriteLine("## Métodos com Parametros ##");

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao("Maria", DateTime.Now.ToShortDateString());

Console.ReadKey();

public class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}