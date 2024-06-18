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
            /*
  Elaborar um programa que possibilite calcular a área total de uma residência (sala, cozinha,
  banheiro, quartos, área de serviço, quintal, garagem, etc.). O programa deve solicitar a entrada do
  nome, a largura e o comprimento de um determinado cômodo. Em seguida, deve apresentar a área
  do cômodo lido e também uma mensagem solicitando do usuário a confirmação de continuar
  calculando novos cômodos. Caso o usuário responda “NAO”, o programa deve apresentar o valor
  total acumulado da área residencial.
*/

            string verificacao = "S";
            string nomeComodo;
            double largura;
            double areaComodo;
            double areaTotal = 0d;

             while (verificacao != "NAO")
            {
                Console.Write("Qual é nome do comodo que voce quer fazer um calculo: ");
                nomeComodo = Console.ReadLine();

                Console.Write("Qual a largura desse cômodo: ");
                largura = double.Parse(Console.ReadLine());

                Console.Write("Qual o comprimento desse cômodo: ");
                double comprimento = double.Parse(Console.ReadLine());

                areaComodo = largura * comprimento;
                areaTotal += areaComodo;
                Console.Write("A area do cômodo " + nomeComodo + " é " + areaComodo +"m²");
                

                
                Console.WriteLine("Deseja calcular a area de mais algum cômodo?");
                verificacao = Console.ReadLine();
                verificacao = verificacao.ToUpper();
                Console.Clear();
            }
            Console.WriteLine("A área total de todos os cômodos é "+ areaTotal + "m²");
            Console.ReadKey();
        }
    }
}
