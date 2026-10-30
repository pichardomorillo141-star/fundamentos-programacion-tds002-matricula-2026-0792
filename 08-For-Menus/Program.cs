/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Actividad de la Semana 8 - Ciclos for, ciclos anidados, triángulo de asteriscos y menú interactivo.
 */

using System;

namespace _08_For_Menus
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("     MENÚ PRINCIPAL - SEMANA 8          ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Mostrar tablas del 1 al 10 (Ciclos anidados)");
                Console.WriteLine("2. Dibujar triángulo de asteriscos (N filas)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("=== TABLAS DE MULTIPLICAR (1 al 10) ===");
                        // Ciclos anidados para mostrar las tablas en columnas alineadas
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.Write($"{i * j,4}");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("=== TRIÁNGULO DE ASTERISCOS ===");
                        Console.Write("Ingrese el número de filas (N): ");
                        
                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Ingrese un número entero positivo válido.");
                        }
                        
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "0":
                        Console.WriteLine("\nSaliendo del programa. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Presione cualquier tecla para intentar de nuevo...");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != "0");
        }
    }
}