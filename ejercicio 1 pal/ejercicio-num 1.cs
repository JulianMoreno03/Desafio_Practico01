using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static bool bandera = true;
        static void Main(string[] args)
        {
            //defenir variales

            const Double pi = 3.14159;
            Double p, cm,plg,a,b;

            //ingrese dos valores
            Console.WriteLine("digite el radio mayor en milimetros");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("digite el radio menor en milimetros");
            b = Double.Parse(Console.ReadLine());

            //inicio de resolucion
            p = pi*(3 * (a + b) - Math.Sqrt((3*a+b)*(3*b+a)));
            cm = p / 10;
            plg = cm / 2.54;

            Math.Round(p);
            Math.Round(cm);
            ;
            Console.WriteLine(" el valor del perimetro en milimetros es: " + Math.Round(p,2) + "mm");
            Console.WriteLine(" el valor de perimetro en centimetros es: " + Math.Round(cm,2) + "cm");
            Console.WriteLine(" el valor del perimetro en pulgadas es: " + Math.Round(plg,2)+"plg");
            Console.WriteLine();
            Console.ReadKey();





        }
    }
}

