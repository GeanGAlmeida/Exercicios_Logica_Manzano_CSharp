using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**Elaborar um programa que efetue a leitura de valores positivos inteiros até que um valor negativo
            seja informado. Ao final devem ser apresentados o maior e o menor valores informados pelo
            usuário. */

            int num;
            int maiorValor = int.MinValue;
            int menorValor = int.MaxValue;

            do
            {
                Console.Write("Digite um valor positivo (ou um valor negativo para encerrar): ");
                num = int.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    if (num > maiorValor)
                    {
                        maiorValor = num;
                    }

                    if (num < menorValor)
                    {
                        menorValor = num;
                    }
                }
            }while (num >= 0);

            Console.WriteLine("Maior valor informado: " + maiorValor);
            Console.WriteLine("Menor valor informado: " + menorValor);

            Console.ReadKey();
        }
    }
}
