using System;
using System.Collections.Generic

namespace MesNumeroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aplicación 'Mes a Número'");
            Console.Write("Por favor, ingrese el nombre de un mes del año: ");
            string nombreMesIngresado = Console.ReadLine();

            string resultado = ObtenerNumeroDelMes(nombreMesIngresado);
            Console.WriteLine(resultado);

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static string ObtenerNumeroDelMes(string nombreMes)
        {
           
            Dictionary<string, int> meses = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
   
                {"enero", 1},
                {"febrero", 2},
                {"marzo", 3},
                {"abril", 4},
                {"mayo", 5},
                {"junio", 6},
                {"julio", 7},
                {"agosto", 8},
                {"septiembre", 9},
                {"octubre", 10},
                {"noviembre", 11},
                {"diciembre", 12}
            };

            
            if (meses.TryGetValue(nombreMes, out int numeroMes))
            {
             
                return $"{nombreMes} + {numeroMes}";
            }
            else
            {
         
                return "Nombre de mes no válido.";
            }
        }
    }
}