using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**Elaborar um programa de computador que efetue a leitura de quatro valores inteiros (variáveis A, B, C e
            D). Ao final o programa deve apresentar o resultado do produto (variável P) do primeiro com o terceiro
            valor, e o resultado do produto (variável P) do primeiro com o terceiro valor, e o resultado da soma
            (variável S) do segundo com o quarto valor */

            Console.Write("Digite o primeiro valor: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valorB = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valorC = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            int valorD = int.Parse(Console.ReadLine());

            int produto = valorA * valorC;
            int soma = valorB + valorD;

            Console.WriteLine("O produto do primeiro valor com o terceiro valor é " + produto);
            Console.WriteLine("A soma do segundo com o quarto valor é " + soma);

            Console.ReadKey();
        }
    }
}
