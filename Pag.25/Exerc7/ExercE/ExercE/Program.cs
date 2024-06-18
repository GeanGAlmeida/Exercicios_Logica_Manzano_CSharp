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
            /*Efetuar o cálculo e a apresentação do valor de uma prestação em atraso, utilizando a fórmula 
            PRESTACAO = VALOR + (VALOR * TAXA/100) * TEMPO).*/

            Console.Write("Valor da divida: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Qual a taxa de atraso: ");
            double taxa = double.Parse(Console.ReadLine());

            Console.Write("Quanto tempo está de atraso: ");
            int tempoAtraso = int.Parse(Console.ReadLine());

            double prestacao = valor + (valor * taxa /100) * tempoAtraso;

            Console.WriteLine(prestacao);

            Console.ReadKey();
        }
    }
}
