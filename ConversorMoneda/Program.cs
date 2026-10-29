/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Descripción: Programa 2 de la Evaluación 02 - Conversor de moneda usando constante y double.
 */

using System;

namespace ConversorMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de constante para la tasa del día (ejemplo: 1 USD = 60.50 DOP)
            const double TASA_USD = 60.50;
            double montoPesos;

            Console.WriteLine("=== CONVERSOR DE MONEDA ===");
            Console.WriteLine($"Tasa de cambio actual: 1 USD = {TASA_USD} DOP");

            // Solicitar monto en pesos
            Console.Write("Ingrese el monto en pesos dominicanos (DOP): ");
            montoPesos = Convert.ToDouble(Console.ReadLine());

            // Calcular equivalente en dólares
            double montoDolares = montoPesos / TASA_USD;

            // Mostrar resultado con interpolación
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine($"Monto ingresado: RD$ {montoPesos:F2}");
            Console.WriteLine($"Equivalente en dólares: US$ {montoDolares:F2}");
            Console.WriteLine("----------------------------------------");
        }
    }
}