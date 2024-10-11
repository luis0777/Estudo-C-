using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        string entrada;

        Console.WriteLine("Insira os nomes (digite 'fim' para terminar):");

        // Leitura de nomes
        while (true)
        {
            entrada = Console.ReadLine();
            if (entrada.ToLower() == "fim")
            {
                break;
            }
            nomes.Add(entrada);
        }

        // Verifica se há nomes suficientes para o sorteio
        if (nomes.Count == 0)
        {
            Console.WriteLine("Nenhum nome foi inserido.");
            return;
        }

        Random random = new Random();
        string continuar;

        do
        {
            int indiceSorteado = random.Next(nomes.Count);
            Console.WriteLine($"O nome sorteado é: {nomes[indiceSorteado]}");

            // Remove o nome sorteado da lista
            nomes.RemoveAt(indiceSorteado);

            // Verifica se ainda há nomes na lista
            if (nomes.Count > 0)
            {
                do
                {
                    Console.WriteLine("Deseja sortear outro nome? (s/n)");
                    continuar = Console.ReadLine().ToLower();

                    if (continuar != "s" && continuar != "n")
                    {
                        Console.WriteLine("Resposta inválida. Por favor, digite 's' para sim ou 'n' para não.");
                    }

                } while (continuar != "s" && continuar != "n");
            }
            else
            {
                Console.WriteLine("Todos os nomes foram sorteados.");
                continuar = "n"; // Termina o loop se não houver mais nomes
            }

        } while (continuar == "s");
    }
}
