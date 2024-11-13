using System;

public class Programa
{
    public static void Main()
    {
        // Aquí se ingresan los 3 valores
        Console.Write("Introducir el valor de a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introducir el valor de b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introducir el valor de c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            // Aquí se muestra el menú
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Validar suma");
            Console.WriteLine("2. Salir");
            Console.Write("Elegir una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if ((a + b == c) || (a + c == b) || (b + c == a))
                    {
                        Console.WriteLine("Son iguales");
                    }
                    else
                    {
                        Console.WriteLine("Son distintos");
                    }
                    break;

                case 2:
                    Console.WriteLine("¡Hasta luego!");
                    return; // Aquí termina el programa

                default:
                    Console.WriteLine("Opción incorrecta, por favor inténtalo de nuevo");
                    break;
            }
        }
    }
}
