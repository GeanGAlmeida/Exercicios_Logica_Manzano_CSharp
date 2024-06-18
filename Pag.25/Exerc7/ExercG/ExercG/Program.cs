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
            /*Ler quatro números inteiros e apresentar o resultado da adição e multiplicação, baseando-se na 
            utilização do conceito da propriedade distributiva. Ou seja, se forem lidas as variáveis A, B, C, e D,
            devem ser somadas e multiplicadas A com B, A com C e A com D. Depois B com C, B com D e por fim 
            C com D. Perceba que será necessário efetuar seis operações de adição e seis operações de 
            multiplicação e apresentar doze resultados de saída.*/

            Console.Write("Digite o valor A: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            int valorB = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor C: ");
            int valorC = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor D: ");
            int valorD = int.Parse(Console.ReadLine());

            Console.Clear();

            int soma = valorA + valorB;
            Console.WriteLine("A soma do valor A mais o valor B é " + soma);

            soma = valorA + valorC;
            Console.WriteLine("A soma do valor A mais o valor C é " + soma);

            soma = valorA + valorD;
            Console.WriteLine("A soma do valor A mais o valor D é " + soma);

            soma = valorB + valorC;
            Console.WriteLine("A soma do valor B mais o valor C é " + soma);

            soma = valorB + valorD;
            Console.WriteLine("A soma do valor B mais o valor D é " + soma);

            soma = valorC + valorD;
            Console.WriteLine("A soma do valor C mais o valor D é " + soma);

            int mult = valorA * valorB;

            Console.WriteLine("A multiplicação do valor A vezes B é " + mult);

            mult = valorA * valorC;
            Console.WriteLine("A multiplicação do valor A vezes C é " + mult);

            mult = valorA * valorD;
            Console.WriteLine("A multiplicação do valor A vezes D é " + mult);

            mult = valorB * valorC;
            Console.WriteLine("A multiplicação do valor B vezes C é " + mult);

            mult = valorB * valorD;
            Console.WriteLine("A multiplicação do valor B vezes D é " + mult);

            mult = valorC * valorD;
            Console.WriteLine("A multiplicação do valor C vezes D é " + mult);

            Console.ReadKey();
        }
    }
}
