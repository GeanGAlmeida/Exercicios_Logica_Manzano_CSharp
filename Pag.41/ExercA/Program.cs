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
            int diferenca;
            //Ler dois valores numéricos inteiros e apresentar o resultado da diferença do maior pelo menor valor.
            Console.Write("Informe o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                diferenca = num1 - num2;
                Console.WriteLine("A diferença dos numeros é " +  diferenca);
            }
            else
            {
                diferenca = num2 - num1;
                Console.WriteLine("A diferença dos numeros é " + diferenca);

            }
            Console.ReadKey();
        }
    }
}
