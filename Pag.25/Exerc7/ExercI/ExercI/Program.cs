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
            /*Ler dois inteiros (variáveis A e B) e imprimir o resultado do quadrado da diferença do primeiro valor pelo
            segundo.*/

            Console.Write("Informe o primeiro valor: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int valorB = int.Parse(Console.ReadLine());

            int diferenca = valorA - valorB;
            double quadrado = Math.Pow(diferenca, 2);

            Console.WriteLine("O quadrado da diferença do valor  A e B é: " + quadrado);

            Console.ReadKey();
        }
    }
}
