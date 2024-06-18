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
            /*Apresentar o total da soma obtida dos cem primeiros números inteiros (1+2+3+4+...+98+99+100)*/
            int count = 0, soma = 0;
            Console.WriteLine("Vamos ver a soma dos 100 primeiro numeros");

            while (count <= 100)
            {
                soma += count;
                count++;
            }
            Console.WriteLine("A soma dos 100 primeiros numeros é " + soma);

            Console.ReadKey();
        }
    }
}
