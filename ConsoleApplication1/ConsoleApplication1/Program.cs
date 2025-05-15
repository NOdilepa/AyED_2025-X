using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Nahuel_Paloni_
{
    class Program
    {

        public static void Main(string[] args)
        {
            double num1, fahrenheit;

            Console.Write("Ingresa el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            {

                fahrenheit = (num1 * 1.8 + 32);
            }

            Console.WriteLine(" El valor fahrenheit es " + fahrenheit);
            Console.ReadKey();

        }
    }
}
