/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa 1 de la Evaluación 05 - Caja registradora usando do-while, contadores y acumuladores.
 */

using System;

namespace CajaRegistradora
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TASA_ITBIS = 0.18;
            double precio, subtotal = 0;
            int cantidadProductos = 0;

            Console.WriteLine("========================================");
            Console.WriteLine("         CAJA REGISTRADORA              ");
            Console.WriteLine("========================================");
            Console.WriteLine("Ingrese los precios de los productos.");
            Console.WriteLine("Escriba 0 (cero) para finalizar la compra.\n");

            do
            {
                Console.Write("Ingrese el precio del producto (0 para terminar): ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out precio))
                {
                    if (precio < 0)
                    {
                        Console.WriteLine("Error: El precio no puede ser negativo.");
                    }
                    else if (precio > 0)
                    {
                        subtotal += precio;
                        cantidadProductos++;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada inválida. Ingrese un número válido.");
                }

            } while (precio != 0);

            // Cálculos finales
            double montoItbis = subtotal * TASA_ITBIS;
            double totalPagar = subtotal + montoItbis;

            // Salida de resultados con formato N2
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("           FACTURA DE COMPRA            ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: RD$ {subtotal:N2}");
            Console.WriteLine($"ITBIS (18%): RD$ {montoItbis:N2}");
            Console.WriteLine($"Total a pagar: RD$ {totalPagar:N2}");
            Console.WriteLine("========================================");
        }
    }
}