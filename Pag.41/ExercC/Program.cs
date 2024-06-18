using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler quatro valores referentes a quatro notas escolares de um aluno e imprimir uma mensagem
dizendo que o aluno foi aprovado, se o valor da média escolar for maior ou igual a 5. Se o aluno não
foi aprovado, indicar uma mensagem informando esta condição. Apresentar junto das mensagens o
valor da média do aluno para qualquer condição*/

            Console.Write("informe a primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("informe a segunda nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("informe a terceiro nota do aluno: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("informe a quarto nota do aluno: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 5)
            {
                Console.WriteLine("O aluno foi aprovado com media " + media);
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado com media de " + media);
            }
            Console.ReadKey();
        }
    }
}
