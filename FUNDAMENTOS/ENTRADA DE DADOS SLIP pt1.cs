using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string frase = Console.ReadLine();    
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();  
        
            Console.WriteLine("voce digitou:  " + frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();
            

            //SLIP
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
