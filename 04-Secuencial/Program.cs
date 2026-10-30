/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa de la Semana 4 - Conversor de unidades usando estructura secuencial, constantes y formato de salida.
 */

using System;

namespace _04_Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de constante para la conversión de libras a kilogramos
            const double LIBRAS_A_KG = 0.453592;

            double pesoLibras, temperaturaFahrenheit;

            Console.WriteLine("========================================");
            Console.WriteLine("       CONVERSOR DE UNIDADES (SECUENCIAL) ");
            Console.WriteLine("========================================");

            // Entrada de datos
            Console.Write("Ingrese el peso en libras (lb): ");
            pesoLibras = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la temperatura en grados Fahrenheit (°F): ");
            temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

            // Procesos (Conversiones)
            double pesoKilogramos = pesoLibras * LIBRAS_A_KG;
            double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5.0 / 9.0;

            // Salida de resultados usando interpolación con formato {valor:F2}
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("             RESULTADOS                 ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Peso ingresado: {pesoLibras:F2} lb");
            Console.WriteLine($"Equivalente en kilogramos: {pesoKilogramos:F2} kg");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Temperatura ingresada: {temperaturaFahrenheit:F2} °F");
            Console.WriteLine($"Equivalente en Celsius: {temperaturaCelsius:F2} °C");
            Console.WriteLine("========================================");
        }
    }
}