/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa 2 de la Evaluación 03 - Factura con columnas alineadas y cálculo de ITBIS.
 */

using System;

namespace Factura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de constante para el ITBIS (18%)
            const double TASA_ITBIS = 0.18;

            string nombreProducto;
            int cantidadProducto;
            double precioUnitario;

            Console.WriteLine("========================================");
            Console.WriteLine("         GENERADOR DE FACTURA           ");
            Console.WriteLine("========================================");

            // Entrada de datos
            Console.Write("Ingrese el nombre del producto: ");
            nombreProducto = Console.ReadLine();

            Console.Write("Ingrese la cantidad: ");
            cantidadProducto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el precio unitario: ");
            precioUnitario = Convert.ToDouble(Console.ReadLine());

            // Procesos
            double subtotal = cantidadProducto * precioUnitario;
            double montoItbis = subtotal * TASA_ITBIS;
            double totalFactura = subtotal + montoItbis;

            // Salida de resultados en columnas alineadas utilizando interpolación con ancho
            Console.WriteLine("\n========================================");
            Console.WriteLine("              FACTURA FISCAL            ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Producto: {nombreProducto}");
            Console.WriteLine($"Cantidad: {cantidadProducto}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{"Subtotal:",-20} RD$ {subtotal,10:N2}");
            Console.WriteLine($"{"ITBIS (18%):",-20} RD$ {montoItbis,10:N2}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{"TOTAL A PAGAR:",-20} RD$ {totalFactura,10:N2}");
            Console.WriteLine("========================================");
        }
    }
}