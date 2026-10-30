/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa 3 de la Evaluación 03 - Cálculos geométricos usando Math.PI, Math.Pow y Math.Sqrt.
 */

using System;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            double radioCirculo, catetoA, catetoB;

            Console.WriteLine("========================================");
            Console.WriteLine("       CÁLCULOS GEOMÉTRICOS             ");
            Console.WriteLine("========================================");

            // Entrada de datos para el círculo
            Console.Write("Ingrese el radio del círculo: ");
            radioCirculo = Convert.ToDouble(Console.ReadLine());

            // Entrada de datos para el triángulo rectángulo
            Console.Write("Ingrese el primer cateto del triángulo: ");
            catetoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo cateto del triángulo: ");
            catetoB = Convert.ToDouble(Console.ReadLine());

            // Procesos del Círculo (Área = PI * r^2, Circunferencia = 2 * PI * r)
            double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
            double circunferenciaCirculo = 2 * Math.PI * radioCirculo;

            // Procesos del Triángulo Rectángulo (Hipotenusa = Sqrt(a^2 + b^2))
            double sumaCatetosCuadrados = Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2);
            double hipotenusaTriangulo = Math.Sqrt(sumaCatetosCuadrados);

            // Salida de resultados con formato de 2 decimales
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("             RESULTADOS                 ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("--- Círculo ---");
            Console.WriteLine($"Área del círculo: {areaCirculo:F2}");
            Console.WriteLine($"Circunferencia: {circunferenciaCirculo:F2}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("--- Triángulo Rectángulo ---");
            Console.WriteLine($"Cateto A: {catetoA:F2} | Cateto B: {catetoB:F2}");
            Console.WriteLine($"Hipotenusa calculada: {hipotenusaTriangulo:F2}");
            Console.WriteLine("========================================");
        }
    }
}