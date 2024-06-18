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
            /*Ler dois valores (inteiros, reais ou caracteres) para as variáveis A e B, e efetuar a troca dos valores de 
            forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da
            variável A. Apresentar os valores trocados*/
            int aux;
            Console.Write("Informe o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valores antes da troca:");
            Console.WriteLine("VALOR 1 = " +  valor1);
            Console.WriteLine("VALOR 2 = " + valor2);

            aux = valor1;
            valor1 = valor2;
            valor2 = aux;

            Console.WriteLine("Valores depois da troca:");
            Console.WriteLine("VALOR 1 = " + valor1);
            Console.WriteLine("VALOR 2 = " + valor2);
            
            Console.ReadKey();
        }
    }
}
