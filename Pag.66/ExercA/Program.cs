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
            //Apresentar os quadrados dos números inteiros de 15 a 200.

            Console.WriteLine("Vamos ver o quadrado de 15 até 200");

            for (int i = 15; i <= 200; i++)
            {
                int quadrado = i * i;
                Console.WriteLine(i + " X " + i + " = " + quadrado);
            }
            Console.ReadKey();
        }
    }
}
