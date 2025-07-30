namespace Beecrowd.codigos;

internal class BEE_1015
{
    public void Executar()
    {
        string[] p1 = Console.ReadLine().Split();
        string[] p2 = Console.ReadLine().Split();

        double x1 = double.Parse(p1[0]);
        double y1 = double.Parse(p1[1]);
        double x2 = double.Parse(p2[0]);
        double y2 = double.Parse(p2[1]);

        double dx = x2 - x1;
        double dy = y2 - y1;

        double distancia = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

        Console.WriteLine($"{distancia:F4}");
    }
     
}
