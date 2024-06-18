using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius. A fórmula de 
conversão é C (F - 32) * (5/9) , sendo F a temperatura em Fahrenheit e C a temperatura em Celsius*/

            Console.WriteLine("Digite uma temperatura em Fahrenheit para converter para Celsius: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32d) * (5d / 9);

            Console.WriteLine("A conversão de " + fahrenheit +"ºF para Celsius é " + celsius+"ºC");

            Console.ReadKey();
        }
    }
}
