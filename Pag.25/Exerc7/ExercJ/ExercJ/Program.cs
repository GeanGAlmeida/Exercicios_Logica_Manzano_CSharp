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
            /*Elaborar um programa que efetue a apresentação do valor da conversão em real de um valor lido em
            dólar. O programa deve solicitar o valor da cotação do dólar e também a quantidade de dólares
            disponível com o usuário, para que seja apresentado o valor em moeda brasileira*/

            Console.Write("Quantos dolares você tem disponivel no momento: ");
            double dolares = double.Parse(Console.ReadLine());

            Console.Write("Qual é a cotação atual do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            double real = dolares * cotacao;

            Console.WriteLine("A conversão de $" + dolares + " dolares para real e de R$" + real);
            Console.ReadKey();
        }
    }
}
