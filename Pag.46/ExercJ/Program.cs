using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que apresente os resultados da soma e da média aritmética dos valores
            pares situados na faixa numérica de 50 a 70.*/

            Console.WriteLine("Vamos ver a soma e a média aritmética do valores pares numa faixa de 50 a 70");
            int count = 50;
            double soma = 0d;
            while (count <= 70)
            {
                if (count % 2 == 0)
                {
                    soma += count;
                }
                count++;
            }
            double media = soma / 10;
            Console.WriteLine("A soma dos valores pares é " + soma + " e a média aritmética é " + media);
            Console.ReadKey();
        }
    }
}
