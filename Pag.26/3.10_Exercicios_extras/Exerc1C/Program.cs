using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Em uma eleição sindical concorreram ao cargo de presidente três candidatos (A, B e C). Durante a
            apuração dos votos foram computados votos nulos e votos em branco, além dos votos válidos para
            cada candidato. Deve ser criado um programa de computador que efetue a leitura da quantidade de
            votos válidos para cada candidato, além de efetuar também a leitura da quantidade de votos nulos e
            votos em branco. Ao final o programa deve apresentar o número total de eleitores, considerando votos
            válidos, nulos e em branco; o percentual correspondente de votos válidos em relação à quantidade de
            eleitores; o percentual correspondente de votos válidos do candidato A em relação à quantidade de
            eleitores; o percentual correspondente de votos válidos do candidato B em relação à quantidade de
            eleitores; o percentual correspondente de votos válidos do candidato C em relação à quantidade de
            eleitores; o percentual correspondente de votos nulos em relação à quantidade de eleitores; e por último
            o percentual correspondente de votos em branco em relação à quantidade de eleitores*/

            Console.Write("Quantos votos teve o canditato A: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Quantos votos teve o canditato B: ");
            int valorB = int.Parse(Console.ReadLine());

            Console.Write("Quantos votos teve o canditato C: ");
            int valorC = int.Parse(Console.ReadLine());

            Console.Write("Quantos foram os votos nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());

            Console.Write("Quantos foram os votos brancos: ");
            int votosBrancos = int.Parse(Console.ReadLine());

           double votosTotais = valorA + valorB + valorC + votosNulos + votosBrancos;

            double votosValidos = ((valorA + valorB + valorC) / votosTotais) * 100d;

            double percentualCanditatoA = valorA / votosTotais * 100d;
            double percentualCanditatoB = valorB / votosTotais * 100d;
            double percentualCanditatoC = valorC / votosTotais * 100d;

            double percentualVotosBrancos = votosBrancos / votosTotais * 100;
            double percentualVotosNulos = votosNulos / votosTotais * 100;

            Console.WriteLine("Foram no total " + Math.Round(votosTotais, 2) + " votos");
            Console.WriteLine("O percentual de votos valídos é " + Math.Round(votosValidos,2) + "%");
            Console.WriteLine("O percentual de votos Do Candidato A é " + Math.Round(percentualCanditatoA,2) + "%");
            Console.WriteLine("O percentual de votos Do Candidato B é " + Math.Round(percentualCanditatoB,2) + "%");
            Console.WriteLine("O percentual de votos Do Candidato C é " + Math.Round(percentualCanditatoC,2) + "%");
            Console.WriteLine("O percentual de votos brancos é " + Math.Round(percentualVotosBrancos,2) + "%");
            Console.WriteLine("O percentual de votos nulos é " + Math.Round(percentualVotosNulos,2) + "%");

            Console.ReadKey();
        }
    }
}
