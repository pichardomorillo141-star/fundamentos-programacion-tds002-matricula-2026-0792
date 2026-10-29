/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Descripción: Programa 1 de la Evaluación 02 - Ficha personal con tipos string, int, double y bool.
 */

using System;

namespace FichaPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables en camelCase
            string nombreCompleto;
            int edadUsuario;
            double estaturaUsuario;
            bool estaTrabajando;
            const int anioActual = 2026;

            // Solicitar datos al usuario
            Console.WriteLine("=== FICHA PERSONAL ===");
            
            Console.Write("Ingrese su nombre: ");
            nombreCompleto = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edadUsuario = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
            estaturaUsuario = Convert.ToDouble(Console.ReadLine());

            Console.Write("¿Trabaja actualmente? (true/false): ");
            estaTrabajando = Convert.ToBoolean(Console.ReadLine());

            // Cálculo del año en que cumplirá 30 años
            int aniosFaltantes = 30 - edadUsuario;
            int anioCumple30 = anioActual + aniosFaltantes;

            // Salida de resultados usando interpolación de cadenas
            Console.WriteLine("\n========================================");
            Console.WriteLine("             DATOS REGISTRADOS          ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Nombre: {nombreCompleto}");
            Console.WriteLine($"Edad: {edadUsuario} años");
            Console.WriteLine($"Estatura: {estaturaUsuario} m");
            Console.WriteLine($"¿Trabaja?: {(estaTrabajando ? "Sí" : "No")}");
            Console.WriteLine($"Año en que cumplirá 30 años: {anioCumple30}");
            Console.WriteLine("========================================");
        }
    }
}