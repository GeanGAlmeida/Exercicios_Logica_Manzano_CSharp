using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de
            1 até 500.*/

            int count = 1, soma = 0;
            Console.WriteLine("Vamos ver a soma dos 500 primeiros numeros pares");

            while (count <= 500)
            {
                if (count % 2 == 0)
                {
                    soma += count;
                }
                count++;
            }
            Console.WriteLine("A soma dos 500 primeiros numeros pares é " + soma);
            Console.ReadKey();
        }
    }
}
