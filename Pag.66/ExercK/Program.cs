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
            int fatorial_total, i, cont;
            for (i = 10; i >= 1; i--)
            {
                if (i % 2 != 0)
                {
                    fatorial_total = 1;
                    for (cont = i; cont >= 1; cont--)
                    {
                        fatorial_total *= cont;
                    }
                    Console.WriteLine("O fatorial de " + i + " é " + fatorial_total);
                }
            }

            Console.ReadKey();
        }
    }
}
