using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int a = 0, b = 1, temp;

        Console.WriteLine("Serie Fibonacci del 1 al 50:");

        while (b <= 50)
        {
            Console.WriteLine(b);
            temp = a + b;
            a = b;
            b = temp;
        }
    }
}