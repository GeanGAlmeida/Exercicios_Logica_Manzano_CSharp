using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**Efetuar a leitura de três valores (variáveis A, B e C) e efetuar o cálculo da equação completa de
segundo grau, apresentando as duas raízes, se para os valores informados for possível efetuar o
referido cálculo. Lembre-se de que a variável A deve ser diferente de zero */

            Console.WriteLine("Digite o primeiro valor");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            int valorB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor");
            int valorC = int.Parse(Console.ReadLine());

            double delta = 0;
            double x1 = 0;
            double x2 = 0;

            if (valorA == 0)
            {
                Console.WriteLine("Impossivel fazer a equação de segundo grau");
            }
            else
            {
                delta = Math.Pow(valorB, 2) - 4 * valorA * valorC;
                Console.WriteLine("O delta vale " + delta);
                if (delta < 0)
                {
                    Console.WriteLine("não existe raizes reais");
                }
                else
                {
                    x1 = (-valorB + Math.Sqrt(delta)) / (2 * valorA);
                    x2 = (-valorB - Math.Sqrt(delta)) / (2 * valorA);
                    Console.WriteLine("As raízes da equação são: " + x1 + " e " + x2);
                }
            }

            Console.ReadKey();
        }
    }
}
