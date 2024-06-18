using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
            Volume *Raio * Altura*/

            Console.WriteLine("Vamos calcular o Volume de uma Lata de òleo.");

            Console.WriteLine("Informe o Raio da lata: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Altura da lata: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine(Math.Round(volume, 2));

            Console.ReadKey();

        }
    }
}
