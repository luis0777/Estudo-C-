namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar: ");
            double dolar = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double compraDolar = double.Parse(Console.ReadLine());

            double resul = Conversor.Converte(dolar, compraDolar);
            Console.Write($"Valor a ser pago em reais é {resul.ToString("F2")} ");
            Console.ReadKey();
        }     
    }
}
