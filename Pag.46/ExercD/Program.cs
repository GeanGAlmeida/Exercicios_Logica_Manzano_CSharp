using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a 20. Para verificar
            se o número é ímpar, efetuar dentro da malha a verificação lógica desta condição com a instrução
            se, perguntando se o número é ímpar; sendo, mostre-o; não sendo, passe para o próximo passo*/
            int count = 0;
            Console.WriteLine("Vamos ver todos os numeros impares em um intervalo de 0 a 20");

            while (count <= 20)
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine(count);
                    
                }
                count++;
            }

            Console.ReadKey();
        }
    }
}
