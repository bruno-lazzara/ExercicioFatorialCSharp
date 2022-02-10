using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int fatorial = 1;

            while (n <= 10)
            {
                fatorial *= n;
                Console.WriteLine("O fatorial de " + n + " = " + fatorial);
                n++;
            }

            Console.ReadLine();
        }
    }
}
