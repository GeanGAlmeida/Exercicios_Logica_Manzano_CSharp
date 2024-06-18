using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Efetuar a leitura de quatro números inteiros e apresentar os números que são divisíveis por 2 e 3*/

            Console.Write("Informe o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            Console.Write("Informe o quarto valor: ");
            int valor4 = int.Parse(Console.ReadLine());

            if (valor1 % 2 == 0 && valor1 % 3 == 0)
            {
                Console.WriteLine("O numero "+ valor1 +" é divisivel por 2 e por 3");
            }
            else
            {
                Console.WriteLine("O numero " + valor1 + " não é divisivel por 2 e por 3");
            }
            if (valor2 % 2 == 0 && valor2 % 3 == 0)
            {
                Console.WriteLine("O numero " + valor2 + " é divisivel por 2 e por 3");
            }
            else
            {
                Console.WriteLine("O numero " + valor2 + " não é divisivel por 2 e por 3");
            }
            if (valor3 % 2 == 0 && valor3 % 3 == 0)
            {
                Console.WriteLine("O numero " + valor3 + " é divisivel por 2 e por 3");
            }
            else
            {
                Console.WriteLine("O numero " + valor3 + " não é divisivel por 2 e por 3");
            }
            if (valor4 % 2 == 0 && valor4 % 3 == 0)
            {
                Console.WriteLine("O numero " + valor4 + " é divisivel por 2 e por 3");
            }
            else
            {
                Console.WriteLine("O numero " + valor4 + " não é divisivel por 2 e por 3");
            }
            Console.ReadKey();
        }
    }
}
