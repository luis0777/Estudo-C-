using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 11; //a RECEBE 10
            Console.WriteLine(a);

            a += 2; // a RECEBE a + 2
            Console.WriteLine(a);

            a *= 3;//a RECEBE a *3
            Console.WriteLine(a);

            a -= 3;// a RECEBE a -3
            Console.WriteLine(a);

            a /= 3; // a RECEBE a divido por 3
            Console.WriteLine(a);

            a %= 5;// a RECEBE o resto da divisão do valor A por 3  
            Console.WriteLine(a);
            Console.ReadKey();




        }
    }
}
