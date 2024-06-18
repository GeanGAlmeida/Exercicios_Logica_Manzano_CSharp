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
            //Apresentar o total da soma obtida dos cem primeiros números inteiros (1+2+3+4+...+98+99+100)

            Console.WriteLine("Soma do 100 primeiros valores");
            int soma = 0;
            for (int i = 0; i <= 100; i++)
            {
                 soma += i;
                
            }
            Console.WriteLine("A soma dos 100 primeiros valores é " + soma);
            Console.ReadKey();
        }
    }
}
