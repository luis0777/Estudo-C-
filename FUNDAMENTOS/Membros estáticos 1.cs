using ConsoleApp1;
using System;
using System.Globalization;

namespace uri1143
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circuferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Circuferencia {circ.ToString("F2")}");
            Console.WriteLine($"Volume {volume.ToString("F2")}");
            Console.WriteLine($"PI {Pi}");

            Console.ReadKey();
        }

        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
