using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Apresentar os resultados de uma tabuada de multiplicar (de 1 até 10) de um número qualquer*/
            int count = 1;
            Console.Write("Digite o numero que voce deseja ver a tabuada: ");
            int num = int.Parse(Console.ReadLine());

            while (count <= 10)
            {
                int resultado = num * count;

                Console.WriteLine(num + " X " + count + " = " + resultado);
                count++;
            }
            Console.ReadKey();
        }
    }
}
