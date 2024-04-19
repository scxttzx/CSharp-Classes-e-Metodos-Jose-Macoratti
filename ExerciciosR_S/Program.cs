

//Console.WriteLine($"Valor da potência antes de incrementar: {x}");
////Console.WriteLine($"Valor de x incrementado(sem sobrecarga): {AumentarPotencia(x)}");
//Console.WriteLine($"Valor da potência incrementada(com sobrecarga): {pot.AumentarPotencia(ref x)}");

Potencia pot = new Potencia();
int x = 10;

Console.WriteLine($"Valor da potência incrementada: {pot.AumentarPotenciaVelocidade(x, out double velocidade)}\nValor final da velocidade: {velocidade}");


Console.ReadKey();

public class Potencia
{
    //public int AumentarPotencia(int potencia)
    //{
    //    potencia += 3;
    //    return potencia;
    //}

    //public int AumentarPotencia(ref int potencia)
    //{
    //    potencia += 5;
    //    return potencia;
    //}

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        velocidade = 100;
        potencia += 7;

        Console.WriteLine("Velocidade inicial: " +  velocidade);

        velocidade = 100 + (potencia * 1.75);

        return potencia;
    }

}