// Programa creado por: Ingrid Guyedes
//Día:17, febrero, 2023
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Programa para determinar el resultado de la compuerta lógica XOR y de una NAND.";
Console.Write("\n\n");
// Declaracion de variables
//cuando v= valor entrada 1 f= valor entrada 2
string a, b;
int op, v, f, c;
//Cálculos
Console.Write("\t Bienvenido/a \n");
Console.Write("\t Programa para determinar el resultado de la compuerta lógica XOR y de una NAND. \n");
Console.Write("\n");
//Diseñamos el menú
Console.Write("\t Selecciona la compuerta que deseas conocer la salida: ");
Console.Write("\n");
Console.Write("\t 1. Compuerta lógica XOR.");
Console.Write("\n");
Console.Write("\t 2. Compuerta lógica NAND.");
Console.Write("\n \t");
op = int.Parse(Console.ReadLine());
Console.Write("\n \t");

//Proceso
switch (op)
{
    case 1:
        Console.Write("\t 1. Compuerta lógica XOR.");
        Console.Write("\n \t"); 
        Console.Write("\t Ingresa el valor de A, puede ser la letra V= 1 o la letra F= 0): ");
        a = Console.ReadLine();
        Console.Write("\t \t Ingresa el valor de B, puede ser la letra V= 1 o la letra F= 0): ");
        b = Console.ReadLine();
        Console.Write("\n \t");
        //Proceso

        if (a==b)
        {
            Console.Write("\t \t Los valores lógicos de salida es F. (F = 0)");
        }
        else
        {
            Console.Write("\t \t Los valores lógicos de salida es V. (V = 1)");
        }
        break;

    case 2:
        Console.Write("\t 2. Compuerta lógica NAND.");
        Console.Write("\n \t");
        Console.Write("\t Ingresa el valor de A, puede ser la V= 1 o F= 0): ");
        v = int.Parse(Console.ReadLine());
        Console.Write("\t \t Ingresa el valor de B, puede ser V= 1 o F= 0): ");
        f = int.Parse(Console.ReadLine());
        Console.Write("\n \t");
        //Proceso
        c = v * f;
        if (c > 0)
        {
            Console.Write("\t \t Los valores lógicos de salida es F. (F = 0)");
        }
        else
        {
            Console.Write("\t \t Los valores lógicos de salida es V. (V = 1)");
        }
        break;

    default:
        Console.WriteLine("\n");
        Console.WriteLine("\t Se ha equivocado de opción solamente puede seleccionar 1 o 2.");
        break;
}
Console.WriteLine("Fin del programa");
Console.ReadKey();




