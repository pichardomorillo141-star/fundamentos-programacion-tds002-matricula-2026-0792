/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa de la Semana 2 sobre variables, constantes y tipos de datos.
 */

using System;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definición de constante y variables
            const int ANIO_ACTUAL = 2026;
            string nombre;
            int edad;
            double estatura;

            // Solicitar datos al usuario
            Console.WriteLine("========================================");
            Console.WriteLine("       PROGRAMA DE VARIABLES Y TIPOS     ");
            Console.WriteLine("========================================");

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su estatura (ej. 1.75): ");
            estatura = Convert.ToDouble(Console.ReadLine());

            // Cálculo del año de nacimiento
            int anioNacimiento = ANIO_ACTUAL - edad;

            // Mostrar resultados usando interpolación de cadenas ($"...")
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("            RESULTADOS                  ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Estatura: {estatura} metros");
            Console.WriteLine($"Año de nacimiento estimado: {anioNacimiento}");
            Console.WriteLine("========================================");
        }
    }
}