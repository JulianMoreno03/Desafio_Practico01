using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 20;  // alto de la ventana           
            Console.WindowWidth = 63; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            // Título
            Console.Title = ("Superficie Total");
            // Declaración de variables
            double a, b, c, d, e, f;
            int opcion;



            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t*           Menu Principal              *");
            Console.WriteLine("\n");
            Console.WriteLine("\t1) Esfera");
            Console.WriteLine("\t2) Piramide");
            Console.WriteLine("\t3) Cono ");
            Console.WriteLine("\n");
            Console.Write("\t--->Digitar la opción deseada (1..3):");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n");
                    Console.WriteLine("\tEsfera");
                    Console.WriteLine("\tDigite el radio de la esfera... ");
                    Console.Write("\t\t");
                    a = Double.Parse(Console.ReadLine());
                    b = Math.Pow(a, 2);
                    c = 4 * 3.14 * b;
                    Console.WriteLine("\tla superficie total de la esfera es :  " + c + "cm²");
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.WriteLine("\n");
                    Console.WriteLine("\tpiramide");
                    Console.WriteLine("\tDigite la base ... ");
                    Console.Write("\t\t");
                    a = Double.Parse(Console.ReadLine());
                    Console.WriteLine("\tDigite la inclinacion ... ");
                    Console.Write("\t\t");
                    b = Double.Parse(Console.ReadLine());
                    c = 4 * a;
                    d = Math.Pow(a, 2);
                    e = 1.0 / 2.0 * (c * b);
                    f = e + d;
                    Console.WriteLine("\tla superficie total de la piramide es:  " + f + "pulgadas²");
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n");
                    Console.WriteLine("\tDigite el radio del cono: ");
                    Console.Write("\t");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("\tDigite la altura del cono: ");
                    Console.Write("\t");
                    b = double.Parse(Console.ReadLine());
                    c = 3.14 * (a * b);
                    d = 3.14 * Math.Pow(a, 2);
                    e = c + d;
                    Console.WriteLine("\tla superficie total de la cono es:  " + e + "pulgadas²");
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.Write("\n)");
                    Console.WriteLine("\tSe ha euivocado de opcion, Solo se acepta de {1 al 3} ");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n");
            Console.Write("\t Fin de ejecucion del programa");
            Console.ReadKey();
        








        }
    }
}
