using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double a, b, c, discriminante, x1, x2;

        Console.WriteLine("Ingrese el valor de a:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de b:");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de c:");
        c = Convert.ToDouble(Console.ReadLine());

        discriminante = b * b - 4 * a * c;

        if (discriminante > 0)
        {
            x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine($"Las soluciones son reales y diferentes: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminante == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine($"La solución es real y doble: x = {x1}");
        }
        else
        {
            Console.WriteLine("Las soluciones son complejas y no reales.");
        }
    }
}