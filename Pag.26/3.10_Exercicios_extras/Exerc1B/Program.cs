using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler o valor correspondente ao salário mensal (variável SM) de um trabalhador e também o valor do
            percentual de reajuste (variável PR) a ser atribuído. Apresentar o valor do novo salário (variável NS)*/

            Console.Write("Qual é o salário mensal do funcionario: ");
            double salarioMensal = double.Parse(Console.ReadLine());

            Console.Write("Qual sera o valor em porcentagem do reajuste: ");
            double reajuste = double.Parse(Console.ReadLine());

            double novoSalario = salarioMensal + (reajuste / 100 * salarioMensal);

            Console.WriteLine("O novo salário do funcionario é R$"+novoSalario);
            Console.ReadKey();
        }
    }
}
