using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que apresente como resultado o valor do fatorial dos valores ímpares
            situados na faixa numérica de 1 a 10.*/

            int fatorialImpar = 10, fatorial, fatorialTotal = 1;

            do
            {
                fatorialImpar--;
                    if (fatorialImpar % 2 != 0)
                    {
                        fatorialTotal = 1;
                        fatorial = fatorialImpar;
                        do
                        {
                            fatorialTotal *= fatorial;
                        fatorial--;
                        }while (fatorial > 0);
                    Console.WriteLine("O fatorial de " +  fatorialImpar + " é " + fatorialTotal);
                    }
            }while (fatorialImpar > 0);
            Console.ReadKey();
        }
    }
}
