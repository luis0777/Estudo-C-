using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("vc digitou " + n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.ReadKey();
            */


            /*
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]); 
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura);
            Console.WriteLine(idade);
            Console.ReadKey();
            */


            Console.WriteLine("entre com seu nome completo: ");
            string nome =  Console.ReadLine();
            Console.WriteLine("quantos quartos tem na sua casa? ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("entre com o preço de um produto: ");
            double preco =  double.Parse(Console.ReadLine());

            Console.WriteLine("entre seu ultimo nome, idade e altura(mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string sobreNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("seu nome é " + nome +  sobreNome + " vc tem " + idade + " anos, na sua casa tem " + quarto + " quarto(s)");
            Console.ReadKey();

        }
    }
}
