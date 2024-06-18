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
            /**/
            Console.WriteLine("Digite qualquer valor para ver se é impar ou par");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) 
            {
                Console.WriteLine(num + " é par");
            }
            else
            {
                Console.WriteLine(num + " é impar");
            }
            Console.ReadKey();
        }
    }
}
