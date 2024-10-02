using System;

namespace estudos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa() { Altura = 150 };
            var brinquedos = new int[] { 100, 120, 130, 150, 180 }; //altura minima para utilizar o brinquedo
            var quantidadesDeBrinquedosPermitidos = 0;


            foreach (var brinquedo in brinquedos)
            {
                if (pessoa.Altura >= brinquedo)
                {
                    quantidadesDeBrinquedosPermitidos++;
                }
            }


            Console.WriteLine(quantidadesDeBrinquedosPermitidos);
            Console.ReadKey();
        }
    }
}
