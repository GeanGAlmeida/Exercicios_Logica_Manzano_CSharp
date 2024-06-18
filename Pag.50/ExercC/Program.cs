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
            /*Apresentar todos os números divisíveis por 4 que sejam menores que 200. Para verificar se o
número é divisível por 4, efetuar dentro da malha a verificação lógica desta condição com a
instrução se, perguntando se o número é divisível; sendo, mostre-o; não sendo, passe para o
próximo passo. A variável que controlará o contador deve ser iniciada com o valor 1*/

            Console.WriteLine("Numero dividiveis por 4 ate 200");

            int count = 1;
            do
            {
                if (count % 4 == 0)
                {
                    
                    Console.WriteLine(count);
                }
                count++;
            } while (count < 200 );
            Console.ReadKey();
        }
    }
}
