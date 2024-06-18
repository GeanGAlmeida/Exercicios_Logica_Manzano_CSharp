using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**Elaborar um programa que possibilite calcular a área total de uma residência (sala, cozinha,
banheiro, quartos, área de serviço, quintal, garagem, etc.). O programa deve solicitar a entrada do
nome, a largura e o comprimento de um determinado cômodo. Em seguida, deve apresentar a área
do cômodo lido e também uma mensagem solicitando do usuário a confirmação de continuar
calculando novos cômodos. Caso o usuário responda “NAO”, o programa deve apresentar o valor
total acumulado da área residencial */

            string comodo, continuar;
            double largura, comprimento, area, somaArea = 0;
            do
            {
                Console.Write("Qual nome do cômodo:");
                comodo = Console.ReadLine();

                Console.Write("Qual a largura do cômodo: ");
                largura = double.Parse(Console.ReadLine());

                Console.Write("Qual o comprimento do cômodo: ");
                comprimento = double.Parse(Console.ReadLine());

                area = comprimento * largura;
                Console.WriteLine("A area desse comodo é " + area);

                somaArea += area;
                Console.WriteLine("Deseja verificar a área novamente? (S/N)");
                continuar = Console.ReadLine();
                continuar = continuar.ToUpper();
            } while (continuar == "S");
            Console.WriteLine("A soma total de todas os comodos é " + somaArea);
            Console.ReadKey();
        }
    }
}
