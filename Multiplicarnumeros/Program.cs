using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicarnumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Multiplicación de Dos Números-");


            try
            {
                Console.Write("Ingresa el primer número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = numero1 * numero2;

                Console.WriteLine($"\nResultado: {numero1} * {numero2} = {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Debes ingresar solo números.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
