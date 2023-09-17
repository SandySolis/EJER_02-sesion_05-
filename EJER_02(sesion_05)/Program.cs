using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base: ");
            int factor1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            int factor2 = int.Parse(Console.ReadLine());
            int resultado = 1;
            for (int i = 0; i < factor2; i++)
            {
                resultado = factor1 * resultado;
            }
            Console.WriteLine("La potencia es: " + resultado +".");
            Console.ReadKey();
        }
    }
}