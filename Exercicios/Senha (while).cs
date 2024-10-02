using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha invalida, clique ENTER para tentar novamente...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
            Console.ReadKey();
        }
    }
}
