using System;

namespace DescuentoDel30
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos un arreglo para almacenar los precios
            double[] precios = { 100, 200, 300, 400 };

            // Porcentaje de descuento
            double porcentajeDescuento = 0.3;

            // Variable para almacenar el descuento total
            double descuentoTotal = 0;

            // Calculamos el descuento para cada precio y lo sumamos al total
            foreach (double precio in precios)
            {
                double descuento = precio * porcentajeDescuento;
                descuentoTotal += descuento;
                Console.WriteLine($"El descuento para el precio {precio} es de: $ {descuento:N2}");
            }

            // Mostramos el descuento total
            Console.WriteLine($"El descuento total es de: ${descuentoTotal:N2}");
        }
    }
}