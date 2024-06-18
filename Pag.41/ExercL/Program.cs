using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que efetue a leitura do nome e do sexo de uma pessoa, apresentando com
saída uma das seguintes mensagens: "Ilmo Sr.", se o sexo informado como masculino, ou a
mensagem "Ilma Sra.", para o sexo informado como feminino. Apresente também junto da
mensagem de saudação o nome previamente informado*/

            Console.Write("Qual seu nome: ");
            string nome = Console.ReadLine();
            nome = nome.ToUpper();

            Console.Write("Qual seu sexo: ");
            char sexo = char.Parse(Console.ReadLine());

            if (sexo == 'm' || sexo == 'M')
            {
                Console.WriteLine("Ola Sr."+ nome + ", Seja bem vindo de volta");
            }
            else if (sexo == 'f' || sexo == 'F')
            {
                Console.WriteLine("Ola Sra." + nome + ", Seja bem vindo de volta");
            }
            else
            {
                Console.WriteLine("Esse sexo não existe");
            }
            Console.ReadKey();

        }
    }
}
