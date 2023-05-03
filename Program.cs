using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double p1;
            double p2;

            Console.Write("insira a nota da P1 da pessoa: ");
            p1 = double.Parse(Console.ReadLine());


            p2 = (3 * 5 - p1) / 2;

            if (p2 <= 10)
                Console.WriteLine("Aluno(a) necessita tirar uma nota {0} ou maior na P2 para passar de ano.", p2);
            else
                Console.WriteLine("Idependente da nota do aluno ese esta Reprovado.");

        }
    }
}
