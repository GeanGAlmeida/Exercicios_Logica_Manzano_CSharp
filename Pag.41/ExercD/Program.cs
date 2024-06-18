using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler quatro valores referentes a quatro notas escolares de um aluno e imprimir uma mensagem
dizendo que o aluno foi aprovado, se o valor da média escolar for maior ou igual a 7. Se o valor da
média for menor que 7, solicitar a nota de exame, somar com o valor da média e obter nova média.
Se a nova média for maior ou igual a 5, apresentar uma mensagem dizendo que o aluno foi
aprovado em exame. Se o aluno não foi aprovado, indicar uma mensagem informando esta
condição. Apresentar com as mensagens o valor da média do aluno, para qualquer condição*/

            Console.Write("informe a primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("informe a segunda nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("informe a terceiro nota do aluno: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("informe a quarto nota do aluno: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado com media de " + media);
            }
            else if (media < 7){
                Console.WriteLine("O aluno esta de recuperção");
                Console.Write("Qual o valor da prova de recuperação: ");
                double notaRecuperacao = double.Parse(Console.ReadLine());
                double novaMedia = (media + notaRecuperacao) / 2;
                if (novaMedia >= 5)
                {
                    Console.WriteLine("O Aluno foi Aprovado por Exame. Nota da Media "+ novaMedia);
                }
                else
                {
                    Console.WriteLine("O Aluno foi Reprovado. Nota da Media " + novaMedia);
                }
            }
           Console.ReadKey();
        }
    }
}
