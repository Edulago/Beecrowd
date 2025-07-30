using System.Security.Cryptography.X509Certificates;

namespace Beecrowd.codigos;

internal class BEE_1014
{
    public void Executar()
    {
        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine());

        double Calcular = (distancia / combustivel);
        Console.WriteLine($"{Calcular.ToString("F3")} km/l");
    }
}
