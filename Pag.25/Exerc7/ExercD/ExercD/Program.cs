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
            Console.WriteLine("Vamos ver quanto de combustivel voce gasta em uma viagem .");

            Console.Write("Quanto tempo foi gasto na viagem: ");
            double tempoGasto = double.Parse(Console.ReadLine());

            Console.Write("Em qual velocidade você andou: ");
            double velocidade = double.Parse(Console.ReadLine());

            double distancia = tempoGasto * velocidade;
            double litrosGastos = distancia / 12d;

            Console.WriteLine("Você andou numa velocidade de " + velocidade + "Km");
            Console.WriteLine("o tempo gasto foi de "+tempoGasto);
            Console.WriteLine("A distancia percorrida foi eu de " + distancia + "Km");
            Console.WriteLine("O total de litros gasto foi de " +  Math.Round(litrosGastos, 2));

            Console.ReadKey();
        }
    }
}
