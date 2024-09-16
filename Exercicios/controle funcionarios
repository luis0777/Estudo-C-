using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, horas;
            float valor, salario;

            Console.WriteLine("controle de funcionarios");
            Console.Write("Digite o numero do funcionario: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Digite quantas horas ele trabalhou: ");
            horas = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor que ele recebe por hora: ");
            valor = float.Parse(Console.ReadLine());    

            salario = horas * valor;

            Console.WriteLine($"\nO funcionario de numero {num} receberá R$ {salario.ToString("F2",CultureInfo.InvariantCulture)} pelas {horas} trabalhadas");
            Console.ReadKey();
        }
    }
}
