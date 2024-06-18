using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Efetuar a leitura de um valor inteiro positivo ou negativo e apresentar o número lido como sendo um
            valor positivo, ou seja, o programa deverá apresentar o módulo de um número fornecido. Lembre-se
            de verificar se o número fornecido é menor que zero; sendo, multiplique-o por -1*/

            Console.Write("Digite um valor positivos ou negativo: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                num = Math.Abs(num);
                Console.WriteLine("O valor negativo foi transformado em positivo "+ num);
            }else
            {
                Console.WriteLine("Voce digitou o valor positivo " + num);
            }

            Console.ReadKey();

        }
    }
}
