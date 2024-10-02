using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONVERSÃO IMPLICITA

            float x = 4.5f;
            double y = x; //essa coversão é possivel pois float tem 4 bytes e o double tem 8 bytes 
            Console.WriteLine(y);

            //CONVERSÃO CASTING

            double a;
            float b;
            a = 5.1;
            b = (float)a; // colocando esse float eu faço o casting para que seja possivel a conversão e assumo o risco de perder dados
            Console.WriteLine(b);

            //nesse caso houve perda de dados
            double d;
            int e;
            d = 5.1;
            e = (int)a;
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
