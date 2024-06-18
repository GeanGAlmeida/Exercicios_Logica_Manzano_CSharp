using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula de 
conversão é F = (9 * C + 160) / 5, sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.
*/

            Console.Write("Digite uma temperatura em Celsius para converter em Fahrenheit: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine("A conversão de " + celsius + "ºC para Fahrenheit é ºF: " + fahrenheit);

            Console.ReadKey();

        }
    }
}
