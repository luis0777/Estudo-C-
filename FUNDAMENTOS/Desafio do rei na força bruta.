using System;

namespace estudos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Start {DateTime.Now}");
            var horizontal = 10000;
            var vertical = 10000;

            var matrix = new int[horizontal, vertical];
            var quantidadeDeRei = 0;
            for (int linha = 0; linha < horizontal; linha++) // 1
            {
                for (int coluna = 0; coluna < vertical; coluna++) // 1
                {
                    var linhaStartScanner = linha > 0 ? linha - 1 : linha;
                    var linhaEndScanner = linha < (horizontal - 1) ? linha + 1 : linha;

                    var ColunaStartScanner = coluna > 0 ? coluna - 1 : coluna;
                    var ColunaEndScanner = coluna < (vertical - 1) ? coluna + 1 : coluna;

                    var ExisteRei = false;

                    for (var l = linhaStartScanner; l <= linhaEndScanner; l++)
                    {
                        for (int c = ColunaStartScanner; c <= ColunaEndScanner; c++)
                        {
                            if (matrix[l, c] == 1)
                            {
                                ExisteRei = true;
                            }
                        }
                    }
                    if (!ExisteRei)
                    {
                        matrix[linha, coluna] = 1;
                        quantidadeDeRei++;
                    }
                }
            }
            Console.WriteLine($"Start {DateTime.Now}");
            Console.WriteLine($"Quantidade maxima de reis no tabuleiro de Dimensão {horizontal}x{vertical} é {quantidadeDeRei:#,##0} Reis");
            Console.WriteLine($"End");
            Console.ReadLine();
        }
    }
}
