using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de
            1 até 500.*/

            Console.WriteLine("Somatória dos valores pares existentes na faixa de 1 até 500");

            int count = 1;
            int soma = 0;

            do
            {
                if (count % 2 == 0)
                {
                    soma += count;
                }
                count++;
            }while (count < 500);
            Console.WriteLine("A soma dos 500 primeiros pares é " + soma);
            Console.ReadKey();
        }
    }
}
