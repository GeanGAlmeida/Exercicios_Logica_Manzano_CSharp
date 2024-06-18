using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            int base1 = 3;

            Console.WriteLine($"{base1} ^ 0 = {result}");

            for ( int i = 1; i <= 15; i++ )
            {
                result *= base1;
                Console.WriteLine($"{base1} ^ {i} = {result}");
            }
            Console.ReadKey();
        }
    }
}
