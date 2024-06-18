using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que efetue a leitura de valores positivos inteiros até que um valor negativo
            seja informado. Ao final devem ser apresentados o maior e o menor valores informados pelo
            usuário.*/

            int num;
            int maiorNumero = int.MinValue;
            int menorNumero = int.MaxValue;
            bool verifcacao = true;
           

            while (verifcacao == true)
            {
                Console.Write("Digite um numero inteiro: ");
                num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    verifcacao = false;
                }
                else
                {
                    if (num > maiorNumero)
                    {
                        maiorNumero = num;
                    }

                    if (num < menorNumero && num > -1)
                    {
                        menorNumero = num;
                    }
                }
            }
            if (maiorNumero == int.MinValue && menorNumero == int.MaxValue)
            {
                Console.WriteLine("Nenhum valor positivo foi informado.");
            }
            else
            {
                Console.WriteLine("O maior valor informado foi: " + maiorNumero);
                Console.WriteLine("O menor valor informado foi: " + menorNumero);
            }
            Console.ReadKey();
        }
    }
}
