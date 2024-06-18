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

            /*Elaborar um programa que efetue a leitura de um valor que esteja entre a faixa de 1 a 9. Após a
leitura do valor fornecido pelo usuário, o programa deverá indicar uma de duas mensagens: "O
valor está na faixa permitida", caso o usuário forneça o valor nesta faixa, ou a mensagem "O valor
está fora da faixa permitida", caso o usuário forneça valores menores que 1 ou maiores que 9*/
            Console.Write("Digite um numero na faixa de 1 a 9: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 9)
            {
                Console.WriteLine("O numero esta na faixa certa.");
            }
            else
            {
                Console.WriteLine("O numero não esta dentro da faixa permitida.");
            }
            Console.ReadKey();
        }
    }
}
