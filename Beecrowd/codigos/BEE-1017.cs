using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.codigos
{
    internal class BEE_1017
    {
        public void Executar()
        {
            double horas = double.Parse(Console.ReadLine());
            double velocidade = double.Parse(Console.ReadLine());

            double Distancia = horas * velocidade;
            double Litros = Distancia / 12;

            Console.WriteLine($"{Litros:F3}");
        }
    }
}
