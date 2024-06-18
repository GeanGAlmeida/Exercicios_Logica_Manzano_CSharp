using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de
1 até 500*/

            Console.WriteLine("Soma dos valores pares existentes na faixa de 1 até 500");
            int soma = 0;
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("Soma dos valores pares existentes na faixa de 1 até 500 é " + soma);
            Console.ReadKey();
        }
    }
}
