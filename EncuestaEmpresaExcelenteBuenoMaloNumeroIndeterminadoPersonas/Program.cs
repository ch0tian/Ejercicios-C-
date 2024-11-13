using System;

public class EncuestaEmpresaExcelenteBuenoMaloNumeroIndeterminadoPersonas
{
    public static void Main()
    {
        int excelente = 0;
        int bueno = 0;
        int malo = 0;

        while (true)
        {
            Console.WriteLine("Por favor, introduzca una calificación (Excelente, Bueno, Malo) o 'Salir' para terminar:");
            string entrada = Console.ReadLine().ToLower();

            if (entrada == "salir")
            {
                break;
            }
            else if (entrada == "excelente")
            {
                excelente++;
            }
            else if (entrada == "bueno")
            {
                bueno++;
            }
            else if (entrada == "malo")
            {
                malo++;
            }
            else
            {
                Console.WriteLine("Calificación no válida. Por favor, intente nuevamente.");
            }
        }

        Console.WriteLine("Resultados de la encuesta:");
        Console.WriteLine($"Excelente: {excelente}");
        Console.WriteLine($"Bueno: {bueno}");
        Console.WriteLine($"Malo: {malo}");
    }
}
