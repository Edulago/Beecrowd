namespace Beecrowd.codigos;
using System.Globalization;

internal class BEE_1006
{
    public void Executar()
    {
        float A = float.Parse(Console.ReadLine());
        float B = float.Parse(Console.ReadLine());
        float C = float.Parse(Console.ReadLine());

        float Media = (A * 2 + B * 3 + C * 5) / 10;

        Console.WriteLine($"MEDIA = {Media.ToString("F1")}");
    }
}
