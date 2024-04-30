Console.WriteLine("## Divisão de números inteiros ##");
Console.WriteLine("x / y");


Console.Write("\nInforme o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

try
{
	int z = x / y;
	Console.WriteLine($"\n{x} / {y} = {z}");
}
catch
{
    Console.WriteLine("\nNão existe divisão por zero, tente outro número...");
}
finally
{
    Console.WriteLine("\nProcessamento concluído...");
}

Console.ReadKey();
