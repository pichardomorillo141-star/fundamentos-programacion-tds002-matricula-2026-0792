/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa 2 de la Evaluación 05 - Juego adivina el número con do-while y contador.
 */

using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Número secreto entre 1 y 100
            int numeroSecreto = Random.Shared.Next(1, 101);
            int intento = 0;
            int contadorIntentos = 0;

            Console.WriteLine("========================================");
            Console.WriteLine("        JUEGO: ADIVINA EL NÚMERO        ");
            Console.WriteLine("========================================");
            Console.WriteLine("He pensado en un número entre 1 y 100. ¡Intenta adivinarlo!\n");

            do
            {
                Console.Write("Ingrese su número: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out intento))
                {
                    contadorIntentos++;

                    if (intento < numeroSecreto)
                    {
                        Console.WriteLine("El número secreto es MAYOR. Sigue intentando.\n");
                    }
                    else if (intento > numeroSecreto)
                    {
                        Console.WriteLine("El número secreto es MENOR. Sigue intentando.\n");
                    }
                    else
                    {
                        Console.WriteLine($"\n¡Felicidades! ¡Adivinaste el número en {contadorIntentos} intentos!");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada inválida. Ingrese un número entero.\n");
                }

            } while (intento != numeroSecreto);

            Console.WriteLine("========================================");
        }
    }
}