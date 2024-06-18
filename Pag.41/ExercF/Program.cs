using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            if(valor1 < valor2 && valor2 < valor3)
            {
                Console.WriteLine("A ordem crescente dos numeros é " + valor1 + ", "+ valor2+ ", "+ valor3);
            }
            else if (valor1 < valor3 && valor3 < valor2)
            {
                Console.WriteLine("A ordem crescente dos numeros é " + valor1 + ", " + valor3 + ", " + valor2);
            }
            else if (valor2 < valor1 && valor1 < valor3)
            {
                Console.WriteLine("A ordem crescente dos numeros é " + valor2 + ", " + valor1 + ", " + valor3);
            }
            else if (valor2 < valor1 && valor1 < valor3)
            {
                Console.WriteLine("A ordem crescente dos numeros é " + valor2 + ", " + valor3 + ", " + valor1);
            }
            else if (valor3 < valor2 && valor2 < valor1)
            {
                Console.WriteLine("A ordem crescente dos numeros é " + valor3 + ", " + valor2 + ", " + valor1);
            }
            else if (valor3 < valor1 && valor1 < valor1)
            {
                Console.WriteLine("A ordem crescente dos numeros é " + valor3 + ", " + valor1 + ", " + valor2);
            }
            Console.ReadKey();
        }
    }
}
