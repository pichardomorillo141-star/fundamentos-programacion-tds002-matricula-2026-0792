/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa de la Semana 3 sobre operadores aritméticos, relacionales y prueba de escritorio.
 */

using System;

namespace _03_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("========================================");
            Console.WriteLine("       PROGRAMA DE OPERADORES           ");
            Console.WriteLine("========================================");

            // Leer dos números enteros
            Console.Write("Ingrese el primer número entero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            // Operaciones
            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            int producto = numero1 * numero2;
            
            // División real (convirtiendo uno a double para no perder decimales)
            double divisionReal = (double)numero1 / numero2;
            
            // División entera y residuo
            int divisionEntera = numero1 / numero2;
            int residuo = numero1 % numero2;

            // Verificar si el primer número es par
            bool esPar = (numero1 % 2 == 0);

            // Mostrar resultados con interpolación
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("             RESULTADOS                 ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Suma: {numero1} + {numero2} = {suma}");
            Console.WriteLine($"Resta: {numero1} - {numero2} = {resta}");
            Console.WriteLine($"Producto: {numero1} * {numero2} = {producto}");
            Console.WriteLine($"División real: {numero1} / {numero2} = {divisionReal:F2}");
            Console.WriteLine($"División entera: {numero1} / {numero2} = {divisionEntera}");
            Console.WriteLine($"Residuo (módulo): {numero1} % {numero2} = {residuo}");
            Console.WriteLine($"¿El primer número ({numero1}) es par?: {esPar}");
            Console.WriteLine("========================================");
        }
    }
}

/*
 ==============================================================================
 PRUEBA DE ESCRITORIO (Valores de ejemplo: x = 10, y = 3)
 ==============================================================================
 | Variable / Expresión         | Operación Matemática       | Resultado      |
 |------------------------------|----------------------------|----------------|
 | int x                        | Entrada                    | 10             |
 | int y                        | Entrada                    | 3              |
 | int suma                     | 10 + 3                     | 13             |
 | int resta                    | 10 - 3                     | 7              |
 | int producto                 | 10 * 3                     | 30             |
 | double divisionReal          | (double)10 / 3             | 3.33           |
 | int divisionEntera           | 10 / 3                     | 3              |
 | int residuo                  | 10 % 3                     | 1              |
 | bool esPar                   | 10 % 2 == 0                | True           |
 ==============================================================================
*/