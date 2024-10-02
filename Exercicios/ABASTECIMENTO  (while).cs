using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Escolha uma das opções abaixo\n1 - alcool\n2 - Gasolina\n3 - Diesel\n4 - Sair");
            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }

                Console.WriteLine("Opção invalida, clique em QUALQUER TECLA para tenntar novamente...");
                Console.Clear();
                Console.Write("Escolha uma das opções abaixo\n1 - alcool\n2 - Gasolina\n3 - Diesel\n4 - Sair");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool} ");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
            Console.ReadKey();
        }
    }
}
