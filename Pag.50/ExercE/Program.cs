using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que efetue a leitura de 15 valores numéricos inteiros e no final apresente o
total do somatório da fatorial de cada valor lido*/
            int i = 1;
            int cont;
            int somaFatorial = 1;
            int fatorial;
            int totalFatorial = 0;

            do
            {
                Console.Write("Digite um numero: ");
                fatorial = int.Parse(Console.ReadLine());
                cont = fatorial;
                do
                {
                    somaFatorial *= fatorial;
                    fatorial -= 1;
                    cont--;
                } while (cont > 0);
                totalFatorial += somaFatorial;
                somaFatorial = 1;
                i++;
            } while (i <= 15);
            Console.WriteLine(totalFatorial);

            Console.ReadKey();
            

        }
    }
}
