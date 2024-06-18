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
            Console.Write("Informe o primeiro Valor: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo Valor: ");
            int valorB = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro Valor: ");
            int valorC = int.Parse(Console.ReadLine());

            double quadrado1 = Math.Pow(valorA, 2);
            double quadrado2 = Math.Pow(valorB, 2);
            double quadrado3 = Math.Pow(valorC, 2);

            Console.WriteLine("O quadrado dos valores A, B, C é A=" + quadrado1 + " B=" + quadrado2 + " C=" + quadrado3);
            double somaQuadrado = quadrado1 + quadrado2 + quadrado3;
            Console.WriteLine("A soma dos tres Valores é "+ somaQuadrado);
            Console.ReadKey();
        }
    }
}
