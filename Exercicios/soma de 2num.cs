using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, resultado;

            Console.WriteLine("Soma de numeros");
            Console.Write("Digite o primeiro numero:  ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine($"A soma de {n1} + {n2} é igual {resultado}");
            Console.ReadKey();

        }
    }
}
