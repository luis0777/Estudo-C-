using ConsoleApp1;
using System;
using System.Globalization;

namespace uri1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int decisao;
            do
            {
                Aluno aluno1 = new Aluno();

                Console.Write("Digite o nome do aluno: ");
                aluno1.Nome = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"Olá {aluno1.Nome}, digite suas notas");
                Console.Write("Nota 1º semestre(até 30): ");
                aluno1.Nota1 = double.Parse(Console.ReadLine());

                while (aluno1.Nota1 > 30)
                {
                    Console.WriteLine("Primeiro semestre vale no maximo até 30, digite a nota corretamente, clique em QUALQUER TECLA PARA CONTINUAR..");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Nota 1º semestre(até 30): ");
                    aluno1.Nota1 = double.Parse(Console.ReadLine());
                }

                Console.Write("Nota 2º semestre(até 35): ");
                aluno1.Nota2 = double.Parse(Console.ReadLine());

                while (aluno1.Nota2 > 35)
                {
                    Console.WriteLine("Segundo semestre vale no maximo até 35, digite a nota corretamente, clique em QUALQUER TECLA PARA CONTINUAR..");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Nota 2º semestre(até 35): ");
                    aluno1.Nota2 = double.Parse(Console.ReadLine());
                }

                Console.Write("Nota 3º semestre(até 35): ");
                aluno1.Nota3 = double.Parse(Console.ReadLine());

                while (aluno1.Nota3 > 35)
                {
                    Console.WriteLine("Terceiro semestre vale no maximo até 35, digite a nota corretamente, clique em QUALQUER TECLA PARA CONTINUAR..");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Nota 3º semestre(até 35): ");
                    aluno1.Nota3 = double.Parse(Console.ReadLine());
                }

                Console.Clear();
                Console.WriteLine($"\nDADOS\n{aluno1}");
                Console.Write($"NOTA FINAL: {aluno1.NotaFinal()}\n");
                aluno1.Status();

                Console.WriteLine("\nDeseja repetir o processo novamente? 1 SIM 2 NÃO");
                decisao = int.Parse(Console.ReadLine());

                while (decisao != 1 && decisao != 2)
                {
                    Console.Clear();
                    Console.WriteLine("Por favor digitamente a tecla correta.");
                    Console.WriteLine("\nDeseja repetir o processo novamente? 1 SIM 2 NÃO");
                    decisao = int.Parse(Console.ReadLine());
                }
                Console.Clear();

            } while (decisao ==  1);
        }

    }
}
