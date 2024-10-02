using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"A raiz quadrada de {x} é {raiz.ToString("F3")}");
                Console.Write("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"O numero {x} é negativo");
            Console.ReadKey();
        }
    }
}
