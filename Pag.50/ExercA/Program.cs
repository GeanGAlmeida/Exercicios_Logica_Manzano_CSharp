using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Apresentar os quadrados dos números inteiros de 15 a 200*/

            Console.WriteLine("Quadrados dos números inteiros de 15 a 200");

            int count = 15;

            do
            {
                double quadrado = Math.Pow(count, 2);
                Console.WriteLine(count + " X " + count + " = " + quadrado);
                count++;
            }while (count <= 200);
            Console.ReadKey();
        }
    }
}
