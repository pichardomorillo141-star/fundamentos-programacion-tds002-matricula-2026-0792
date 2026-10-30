/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa de la Semana 7 - Uso de ciclos do-while y while para validación, tabla de multiplicar y acumulador.
 */

using System;

namespace _07_Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("========================================");
            Console.WriteLine("    ACTIVIDAD SEMANA 7: CICLOS         ");
            Console.WriteLine("========================================");

            // 1. Pide un número entre 1 y 12 y valídalo con do-while
            do
            {
                Console.Write("Ingrese un número entero entre 1 y 12: ");
                string entrada = Console.ReadLine();

                // Validar que sea un número entero y esté en el rango correcto
                if (int.TryParse(entrada, out numero))
                {
                    if (numero < 1 || numero > 12)
                    {
                        Console.WriteLine("Error: El número debe estar estrictamente entre 1 y 12. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada inválida. Debe ingresar un número entero.");
                    numero = 0; // Forzar a que continúe en el ciclo
                }

            } while (numero < 1 || numero > 12);

            Console.WriteLine($"\n¡Número válido aceptado: {numero}!\n");
            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"      TABLA DE MULTIPLICAR DEL {numero} ");
            Console.WriteLine($"----------------------------------------");

            // 2. Muestra su tabla de multiplicar del 1 al 12 con while y un contador
            int contador = 1;
            int sumaResultados = 0; // 3. Acumulador de la suma de todos los resultados

            while (contador <= 12)
            {
                int resultado = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {resultado}");

                // Acumular el resultado
                sumaResultados += resultado;

                // Incrementar contador
                contador++;
            }

            // 3. Al final, muestra la suma de todos los resultados
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Suma total de todos los resultados: {sumaResultados}");
            Console.WriteLine("========================================");
        }
    }
}