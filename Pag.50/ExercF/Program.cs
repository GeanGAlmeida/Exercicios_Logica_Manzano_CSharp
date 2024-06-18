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
            /*Elaborar um programa que efetue a leitura sucessiva de valores numéricos e apresente no final o
total do somatório, a média aritmética e o total de valores lidos. O programa deve fazer as leituras
dos valores enquanto o usuário estiver fornecendo valores positivos. Ou seja, o programa deve
parar quando o usuário fornecer um valor negativo. Não se esqueça que o usuário pode entrar
como primeiro número um número negativo, portanto, cuidado com a divisão por zero no cálculo da
média.*/
            int num, count = 0, soma = 0;
            double mediaAritmetica;

            do
            {
                Console.WriteLine("Digite uma numero qualquer (para interromper basta digitar um numero negativo)");
                num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    soma += num;
                        count++;
                }
            }while (num >= 0);
            if (count > 0)
            {
                mediaAritmetica = soma /count;
                Console.WriteLine("A soma de todos os numero digitados é " + soma);
                Console.WriteLine("A media aritmética de todos os numeros digitado é " + mediaAritmetica);
                Console.WriteLine("Foram lidos no total " + count + " numeros");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
