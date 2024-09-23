using ConsoleApp1;
using System;
using System.Globalization;

namespace uri1143
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produtos");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine()); 
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto {p}\n");

            Console.WriteLine("Digite o numero de produtos a serem adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine($"Dados atualizado {p}");

            Console.WriteLine("Digite o numero de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine($"\nDados atualizado {p}\n");
            Console.ReadKey();
        }
    }
}
