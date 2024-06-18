using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que apresente a série de Fibonacci até o décimo quinto termo. A série de
            Fibonacci é formada pela seqüência: 1, 1, 2, 3, 5, 8, 13, 21, 34, ..., etc. Esta série se caracteriza
            pela soma de um termo atual com o seu anterior subseqüente, para que seja formado o próximo
            valor da seqüência. Portanto começando com os números 1, 1 o próximo termo é 1+1=2, o próximo
            é 1+2=3, o próximo é 2+3=5, o próximo 3+5=8, etc*/

            Console.WriteLine("Série de Fibonacci");

            int num1 = 0, num2 = 1, result;

            for (int i = 1; i <= 15; i++)
            {
                result = num1 + num2;
                num1 = num2;
                num2 = result;
                Console.Write(result + ", ");
            }
            
            Console.ReadKey();
        }
    }
}
