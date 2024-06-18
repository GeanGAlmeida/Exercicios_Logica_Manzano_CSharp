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
            /*Apresentar todos os números divisíveis por 4 que sejam menores que 200. Para verificar se o
            número é divisível por 4, efetuar dentro da malha a verificação lógica desta condição com a
            instrução se, perguntando se o número é divisível; sendo, mostre-o; não sendo, passe para o
            próximo passo. A variável que controlará o contador deve ser iniciada com o valor 1*/

            Console.WriteLine("Numeros divisiveis por 4 que sejam menores que 200");

            for (int i = 1; i <= 200; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
