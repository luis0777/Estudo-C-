using System;

namespace estudos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var minhasVogais = new string[] { "a", "e", "i", "o", "u","A","E","I","O","U" };
            var texto = "eu preciso estudar muito mais";
            var vogais = 0;
            var consoantes = 0;

            foreach (var item in texto)
            {
                if(char.IsLetter(item))
                {
                    if(Array.Exists(minhasVogais, v => v == item.ToString()))
                    {
                        vogais++; 
                    }
                    else
                    {
                        consoantes++; 
                    }
                }
            }
            Console.WriteLine($"O texto possuiu {vogais} vogais e {consoantes} consoantes");
            Console.ReadKey(); 
        }
    }
}
