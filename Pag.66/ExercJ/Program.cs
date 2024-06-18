using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que apresente os valores de conversão de graus Celsius em Fahrenheit, de
               10 em 10 graus, iniciando a contagem em 10 graus Celsius e finalizando em 100 graus Celsius. O
               programa deve apresentar os valores das duas temperaturas*/

            double fahrenheit;

            for (int celsius = 10; celsius <= 100; celsius += 10)
            {
                fahrenheit = (9 * celsius + 160) / 5;
                Console.WriteLine($"Graus Celsius: {celsius} ºC | Graus em fahrenheit: {fahrenheit}ºF");
            }
            Console.ReadKey();
        }
    }
}
