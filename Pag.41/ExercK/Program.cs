using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que efetue a leitura de um determinado valor inteiro, e efetue a sua
apresentação, caso o valor não seja maior que três.*/

            Console.Write("Digite um valor menor que 3: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 3)
            {
                Console.WriteLine("Esse numero é maior que 3, não esta na faixa permitida");
            }
            else
            {
                Console.WriteLine("O numero " +  num + " esta na faixa permitida");
            }
            Console.ReadKey();
        }
    }
}
