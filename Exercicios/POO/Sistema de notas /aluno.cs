using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    public class Aluno
    {
        
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public void Status()
        {
            if (NotaFinal() >= 60.00)
            {
                Console.WriteLine($"PARABÉNS {Nome} você está aprovado!!");
            }
            else
            {
                double Reprovado = 60.00 - NotaFinal();
                Console.WriteLine($"INFELIMENTE {Nome} você está reprovado, faltaram {Reprovado.ToString("F2")} pontos");
            }

        }

        public override string ToString()
        {
            return $"Aluno(a): {Nome}\nNota 1º trimestre: {Nota1}\nNota 2º trimestre: {Nota2}\nNota 3º trimestre: {Nota3}";
        }
    }
}
