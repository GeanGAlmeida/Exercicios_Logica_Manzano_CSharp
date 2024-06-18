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
            /**Elaborar um programa que apresente o resultado inteiro da divisão de dois números quaisquer.
            Para a elaboração do programa, não utilizar em hipótese alguma o conceito do operador aritmético
            DIV. A solução deve ser alcançada com a utilização de looping. Ou seja, o programa deve
            apresentar como resultado (quociente) quantas vezes o divisor cabe no dividendo */
            Console.Write("Digite o dividendo: ");
            int dividendo = int.Parse(Console.ReadLine());

            Console.Write("Digite um divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            int quociente = 0;
            int resto = dividendo;

            do
            {
                resto -= divisor;
                quociente++;
            } while (resto >= divisor);
            Console.WriteLine("Resultado inteiro da divisão: " + quociente);
            Console.ReadKey();
        }
    }
}
