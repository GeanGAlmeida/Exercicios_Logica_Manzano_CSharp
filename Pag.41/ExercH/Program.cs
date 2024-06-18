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
            /*Efetuar a leitura de cinco números inteiros e identificar o maior e o menor valores*/

            Console.Write("Informe o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.Write("Informe o quarto valor: ");
            int n4 = int.Parse(Console.ReadLine());

            Console.Write("Informe o quinto valor: ");
            int n5 = int.Parse(Console.ReadLine());

            int maior = 0;
            int menor = 0;

            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
            {
                maior = n1;
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
            {
                maior = n2;
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                maior = n3;
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
            {
                maior = n4;
            }
            else if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4)
            {
                maior = n5;
            }

            if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5)
            {
                menor = n1;
            }
            else if (n2 < n1 && n2 < n3 && n2 < n4 && n2 < n5)
            {
                menor = n2;
            }
            else if (n3 < n1 && n3 < n2 && n3 < n4 && n3 < n5)
            {
                menor = n3;
            }
            else if (n4 < n1 && n4 < n2 && n4 < n3 && n4 < n5)
            {
                menor = n4;
            }
            else if (n5 < n1 && n5 < n2 && n5 < n3 && n5 < n4)
            {
                menor = n5;
            }

            Console.WriteLine("O maior numero é " + maior + " e o menor é " + menor);

            Console.ReadKey();
        }
    }
}
