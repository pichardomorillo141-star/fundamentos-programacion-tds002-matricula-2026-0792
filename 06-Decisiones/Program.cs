/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa de la Semana 6 - Estructuras de decisión (if-else y switch).
 */

using System;

namespace _06_Decisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("    ACTIVIDAD SEMANA 6: DECISIONES      ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Calificación por letras");
            Console.WriteLine("2. Calculadora con switch");
            Console.Write("Seleccione una opción (1 o 2): ");
            
            string opcionMenu = Console.ReadLine();

            if (opcionMenu == "1")
            {
                // ==========================================
                // PARTE 1: CALIFICACIÓN
                // ==========================================
                Console.WriteLine("\n--- PARTE 1: EVALUACIÓN DE NOTA ---");
                Console.Write("Ingrese una nota (0 - 100): ");
                string entradaNota = Console.ReadLine();

                // Validar con int.TryParse
                if (int.TryParse(entradaNota, out int nota))
                {
                    // Validar rango de 0 a 100
                    if (nota >= 0 && nota <= 100)
                    {
                        string letraCalificacion;

                        // Estructura if - else if - else
                        if (nota >= 90)
                        {
                            letraCalificacion = "A";
                        }
                        else if (nota >= 80)
                        {
                            letraCalificacion = "B";
                        }
                        else if (nota >= 70)
                        {
                            letraCalificacion = "C";
                        }
                        else
                        {
                            letraCalificacion = "F";
                        }

                        Console.WriteLine($"Nota ingresada: {nota} -> Calificación: [{letraCalificacion}]");
                    }
                    else
                    {
                        Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada inválida. Debe ingresar un número entero.");
                }
            }
            else if (opcionMenu == "2")
            {
                // ==========================================
                // PARTE 2: CALCULADORA
                // ==========================================
                Console.WriteLine("\n--- PARTE 2: CALCULADORA BÁSICA ---");
                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nOperaciones disponibles:");
                Console.WriteLine("1. Sumar (+)");
                Console.WriteLine("2. Restar (-)");
                Console.WriteLine("3. Multiplicar (*)");
                Console.WriteLine("4. Dividir (/)");
                Console.Write("Seleccione la operación (1-4): ");
                
                string operacion = Console.ReadLine();
                double resultado = 0;
                bool operacionValida = true;

                // Estructura switch para seleccionar la operación
                switch (operacion)
                {
                    case "1":
                        resultado = num1 + num2;
                        Console.WriteLine($"\nResultado de la suma: {num1} + {num2} = {resultado:F2}");
                        break;
                    case "2":
                        resultado = num1 - num2;
                        Console.WriteLine($"\nResultado de la resta: {num1} - {num2} = {resultado:F2}");
                        break;
                    case "3":
                        resultado = num1 * num2;
                        Console.WriteLine($"\nResultado del producto: {num1} * {num2} = {resultado:F2}");
                        break;
                    case "4":
                        // Validación de división entre cero
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"\nResultado de la división: {num1} / {num2} = {resultado:F2}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: No se puede dividir entre cero.");
                            operacionValida = false;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError: Opción de operación no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción principal no válida.");
            }

            Console.WriteLine("========================================");
        }
    }
}