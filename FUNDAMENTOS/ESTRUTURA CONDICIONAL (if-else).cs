using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("qual a hora atual?  ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("BOM DIA");
            }
            else if(hora < 18)
            {
                Console.WriteLine("BOA TARDE");
            }
            else
            {
                Console.WriteLine("BOA NOITE");
            }

            Console.ReadKey();
        }
    }
}
