using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            Double salario, horas, extra, horasExtras;

            extra = 1.25;
            //Enunciado 
            Console.Write("\n\n");
            Console.WriteLine("\tUn Obrero necesita calcular su salario semanal ");
            Console.Write("\n\n");

            
            //Entrada de datos 
            Console.Write("\t¿Cuanto gana el obrero por HORA?...: ");
            salario = Double.Parse(Console.ReadLine());
            Console.Write("\n\n");

            Console.Write("\t¿Cuantas horas a la semana trabaja el obrero?...: ");
            horas = Double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("\n\n");
            
            Console.Write("\tPresiona cualquier tecla para calcular el salario");
            Console.ReadKey();
            Console.Clear();


            if (horas <= 30) 
            {
                Console.Write("\n\n");
                Console.Write("\tAl obrero se le paga su salario semanal normal");
                salario = salario * horas;
                Console.Write("\n\n");
                Console.Write("\tSu salario semanal es de... " + salario);

            }
                else if (horas > 30 && horas < 168 )
                {
                    Console.Write("\n\n");
                    Console.Write("\tAl obrero se le paga su horario normal, mas un bono por cada hora del 125%");
                    //Calculamos cuantas horas extras trabajo 
                    horasExtras = horas - 30;
                    //Aumentamos el valor de las horas
                    horasExtras = horasExtras * extra;
                    Console.Write("\n\n");
                    Console.Write("\tAl obrero se le paga un bono de " + horasExtras);
                    Console.Write("\n\n");
                 
                    salario = salario * horas + horasExtras; 
                 
                 
                    salario = salario * horas + horasExtras;
                    
                    Console.Write("\n\n");
                    Console.Write("\tSu salario semanal es de... " + salario);
                }
                   else
                        {
                            Console.Write(" ERORR ");
                            Console.Write("\n\n\n");
                            Console.Write("\tEl obrero no puede trabajar tanto :( "); 
                        }

                  

        }
    }
}
