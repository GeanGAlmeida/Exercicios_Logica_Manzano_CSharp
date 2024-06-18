using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que calcule e apresente o volume de uma caixa retangular, por meio da fórmula
            VOLUME = COMPRIMENTO * LARGURA * ALTURA*/

            Console.Write("Informe a largura da caixa: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Informe o comprimento da caixa: ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura da caixa: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = comprimento * largura * altura;

            Console.WriteLine("O Volume da caixa é " + volume);

            Console.ReadKey();
        }
    }
}
