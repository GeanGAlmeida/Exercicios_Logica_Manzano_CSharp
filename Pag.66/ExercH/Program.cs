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
            /*Elaborar um programa que apresente como resultado o valor de uma potência de uma base
            qualquer elevada a um expoente qualquer, ou seja, de BE, em que B é o valor da base e E o valor
            do expoente. Observe que neste exercício não pode ser utilizado o operador de exponenciação do
            portuguol (^)*/

            Console.Write("Qual a base da operação: ");
            int base1 =int.Parse(Console.ReadLine());

            Console.Write("Qual é o expoente da operação: ");
            int expoente = int.Parse(Console.ReadLine());

            int result = 1;

            for(int i = 1; i < expoente; i++)
            {
                result *= base1;
            }

            Console.WriteLine($"{base1} ^ {expoente} = {result}");
            Console.ReadKey();
        }
    }
}
