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
            //Apresentar os resultados de uma tabuada de multiplicar (de 1 até 10) de um número qualquer.

            Console.Write("Digite um numero para ver sua tabuada ate o 10: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int mult = num * i;
                Console.WriteLine(num + " X " + i + " = " + mult);
            }
            Console.ReadKey();
        }
    }
}
