using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año = 1900;

            Console.WriteLine("Años bisiestos desde 1900 hasta 2023: ");

            while (año <= 2023)
            {
                if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                {
                    Console.WriteLine(año);
                }
                año++;
            }
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
