using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que efetue a apresentação do valor da conversão em dólar de um valor lido em
            real. O programa deve solicitar o valor da cotação do dólar e também a quantidade de reais disponível
            com o usuário, para que seja apresentado o valor em moeda americana*/

            Console.Write("Quantos reais você tem disponivel no momento: ");
            double real = double.Parse(Console.ReadLine());

            Console.Write("Qual é a cotação atual do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            double dolares = real / cotacao;

            Console.WriteLine("A conversão de R$" + real + " reais para dolares e de $" + Math.Round(dolares, 2));
            Console.ReadKey();
        }
    }
}
