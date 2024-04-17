Console.WriteLine("## Argumentos por referência - out ##\n");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();
//double perimetro = circulo.CalculaPerimetro(raio);
//double area = circulo.CalculaArea(raio);

double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);
Console.WriteLine("Perímetro do círculo: " + circunferencia);
Console.WriteLine("Área do círculo: " + area);

Console.ReadKey();

public class Circulo
{

    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
    public double CalculaArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }
    public double CalculaPerimetro(double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}