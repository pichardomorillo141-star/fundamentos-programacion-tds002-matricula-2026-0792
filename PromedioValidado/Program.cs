/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa 3 de la Evaluación 05 - Cálculo de promedio, nota mayor y nota menor con validación.
 */

using System;

namespace PromedioValidado
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double sumaNotas = 0;
            int cantidadNotas = 0;
            double notaMayor = double.MinValue;
            double notaMenor = double.MaxValue;

            Console.WriteLine("========================================");
            Console.WriteLine("       PROMEDIO Y ESTADÍSTICAS DE NOTAS ");
            Console.WriteLine("========================================");
            Console.WriteLine("Ingrese notas válidas (0 - 100).");
            Console.WriteLine("Escriba -1 para finalizar y calcular resultados.\n");

            do
            {
                Console.Write("Ingrese una nota (-1 para terminar): ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out nota))
                {
                    if (nota == -1)
                    {
                        break; // Salir del ciclo si escribe -1
                    }
                    else if (nota >= 0 && nota <= 100)
                    {
                        sumaNotas += nota;
                        cantidadNotas++;

                        // Evaluar nota mayor y menor
                        if (nota > notaMayor)
                        {
                            notaMayor = nota;
                        }
                        if (nota < notaMenor)
                        {
                            notaMenor = nota;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada inválida. Ingrese un valor numérico.");
                }

            } while (true);

            // Mostrar resultados si se ingresaron notas
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("           RESULTADOS FINALES           ");
            Console.WriteLine("----------------------------------------");
            if (cantidadNotas > 0)
            {
                double promedio = sumaNotas / cantidadNotas;
                Console.WriteLine($"Total de notas ingresadas: {cantidadNotas}");
                Console.WriteLine($"Promedio general: {promedio:N2}");
                Console.WriteLine($"Nota más alta: {notaMayor:N2}");
                Console.WriteLine($"Nota más baja: {notaMenor:N2}");
            }
            else
            {
                Console.WriteLine("No se ingresaron notas válidas para calcular estadísticas.");
            }
            Console.WriteLine("========================================");
        }
    }
}