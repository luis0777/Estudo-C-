using ConsoleApp1;
using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circuferencia {circ.ToString("F2")}");
            Console.WriteLine($"Volume {volume.ToString("F2")}");
            Console.WriteLine($"PI {Calculadora.Pi }");

            Console.ReadKey();
        }

        
    }
}
