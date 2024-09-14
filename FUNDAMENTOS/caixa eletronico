using System;

namespace estudos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notas = new[] { 100, 50, 20, 10, 5, 2, 1 };
            var valorSaque = 695;

            foreach (var cedula in notas)
            {
                int quantidade = valorSaque / cedula;
                valorSaque %= cedula;
                if (quantidade > 0)
                {
                    Console.WriteLine($"Notas de {cedula}: {quantidade}");

                }
            }
        }
    }
}
