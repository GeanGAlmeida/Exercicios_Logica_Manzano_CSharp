using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que efetue a leitura de 10 valores numéricos e apresente no final o total do
            somatório e a média aritmética dos valores lidos*/
           

            int count = 1;
            double soma = 0;
            while (count <= 10)
            {
                Console.Write("Digite o " + count + "º numero: ");
                double num = double.Parse(Console.ReadLine());
                soma += num;

                count++;
            }
            count = count - 1;
            double mediaAritmetica = soma / count;
            Console.WriteLine("A soma dos 10 valores digitados é " + soma);
            Console.WriteLine("A media aritmética da soma é " + Math.Round(mediaAritmetica, 2));
            Console.ReadKey();
        }
    }
}
