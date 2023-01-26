using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double a = 7; double b = 6; double c = 0; double d = 0; double f = 0; double g = 0; double j = 0; double k = 0;
            c = a + b;
            d = a - b;
            f = a * b;
            g = a / b;
            j = a % b;
            k = Math.Sin(a);
            //after reset
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.ReadLine();

        }
    }
}