using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisis_de_resultados_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 80;
            Console.WindowWidth = 80;

            //Declaramos variables
            double preguntasCorrectas, totalPreguntas, PROM;

             

            Console.Title = "Test de capacitacion";
            //Entrada de datos
            Console.Write("\n\n");
            Console.Write("\t\tEscriba el numero total de preguntas...: ");
            totalPreguntas = int.Parse(Console.ReadLine());

            Console.Write("\n\n");
            Console.Write("\t\tEscriba el numero de preguntas contestadas correctamente...:");
            preguntasCorrectas = int.Parse(Console.ReadLine());
            Console.Write("\n\n");

            //Salida

            PROM = preguntasCorrectas / totalPreguntas *100;

            Console.WriteLine("\t\tPresiona cualquier tecla para calcular tu resultado");
            Console.ReadKey();
            Console.Write("\n\n");
            if (PROM >= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t\tEl promedio de preguntas correctas es de nivel maximo");
            }
            else if (PROM >= 75 && PROM < 90)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\t\tEl promedio de preguntas correctas es de nivel medio");
            }
            else if ( PROM >= 50 && PROM <75)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\t\tEl promedio de preguntas correctas es de nivel bajo");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tEl promedio esta fuera de nivel");
            }

            Console.Write("\n\n");
            Console.Write("\t\tTu promedio es de...: "+ Math.Round(PROM,2) + "%");
            Console.Write("\n\n"); 
            Console.ReadKey();

            Console.WriteLine("\t*************************************************************");
            Console.WriteLine("\t\t*                                        *");
            Console.WriteLine("\t\t*     Este programa fue diseñado por:    *");
            Console.WriteLine("\t\t*                                        *");
            Console.WriteLine("\t\t*             Julian Moreno              *");
            Console.WriteLine("\t\t*                                        *");
            Console.Write("\t");
           
            Console.WriteLine("*************************************************************");

            Console.Write("\t\t\t Fin del programa ----->");
            Console.ReadKey();
        }
    }
}
