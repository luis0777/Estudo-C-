using ConsoleApp1;
using System;

namespace uri1143
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            a.Nome = Console.ReadLine();
            Console.Write($"Digite a idade da {a.Nome}: ");
            a.idade = int.Parse( Console.ReadLine() );

            Console.Write("Digite o nome da segunda pessoa: ");
            b.Nome = Console.ReadLine();
            Console.Write($"Digite a idade da {b.Nome}: ");
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade) Console.WriteLine($"Pessoa mais velha: {a.Nome}");
            else if (b.idade > a.idade) Console.WriteLine($"Pessoa mais velha: {b.Nome}");
            else Console.WriteLine($"{a.Nome} e {b.Nome} tem a mesma idade");

            Console.ReadKey();
        }
    }
}
