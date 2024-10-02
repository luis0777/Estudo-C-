using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write($"Olá senhor(a) {nome}, por favor digite qual é o seu salario:  ");
            float salario = float.Parse(Console.ReadLine());

            if (salario <= 2000) 
                Console.WriteLine($"Como seu salario é R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}, você está ISENTO ");
            else if(salario <= 3000)
            {
                float taxa = salario * 0.08F;
                Console.WriteLine($"Como seu salario é R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}, você irá pagar R$ {taxa} de taxa");
            }
            else if(salario <= 4500)
            {
                float taxa = salario * 0.18F;
                Console.WriteLine($"Como seu salario é R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}, você irá pagar R$ {taxa} de taxa");
            }
            else
            {
                float taxa = salario * 0.28F;
                Console.WriteLine($"Como seu salario é R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}, você irá pagar R$ {taxa} de taxa");
            }
            Console.ReadKey();
        }
    }
}
