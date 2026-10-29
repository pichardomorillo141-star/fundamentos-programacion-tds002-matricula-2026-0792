/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Descripción: Programa 3 de la Evaluación 02 - Demostración de casting explícito e implícito.
 */

using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDecimal;

            Console.WriteLine("=== DEMOSTRACIÓN DE CASTING ===");

            // Solicitar número con decimales
            Console.Write("Ingrese un número con decimales (ej. 98.75): ");
            numeroDecimal = Convert.ToDouble(Console.ReadLine());

            // 1. Casting explícito (de double a int): Se truncan los decimales
            int parteEntera = (int)numeroDecimal;

            // 2. Casting implícito (de int a double): Conversión automática sin pérdida
            int numeroEnteroBase = 50;
            double numeroConvertidoImplicito = numeroEnteroBase;

            // Mostrar resultados con interpolación
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine($"Número decimal original (double): {numeroDecimal}");
            Console.WriteLine($"Casting explícito a entero (int): {parteEntera}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Entero base (int): {numeroEnteroBase}");
            Console.WriteLine($"Casting implícito a double: {numeroConvertidoImplicito}");
            Console.WriteLine("----------------------------------------");
        }
    }
}