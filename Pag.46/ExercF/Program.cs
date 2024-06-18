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
            /*Elaborar um programa que apresente como resultado o valor de uma potência de uma base
            qualquer elevada a um expoente qualquer, ou seja, de BE, em que B é o valor da base e E o valor
            do expoente. Observe que neste exercício não pode ser utilizado o operador de exponenciação do
            portuguol (^).*/

            Console.Write("Informe o valor do base: ");
            int base1 = int.Parse(Console.ReadLine());

            Console.Write("Agora informe o valor do expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            int resultado = 1;
            int count = 0;
            while (count < expoente)
            {
                resultado *= base1;
                count++;
            }
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
