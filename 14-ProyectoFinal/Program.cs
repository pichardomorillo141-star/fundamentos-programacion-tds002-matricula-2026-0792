/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Proyecto Final Integrador - Fundamentos de Programación (TDS002).
 * Sistema de gestión con menú principal que integra operaciones, conversiones, validaciones y ciclos.
 */

using System;

namespace _14_ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcionPrincipal;

            do
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("    PROYECTO FINAL - FUNDAMENTOS DE PROGRAMACIÓN  ");
                Console.WriteLine("    Estudiante: Alex Rafael Pichardo Morillo      ");
                Console.WriteLine("    Matrícula: 2026-0792 | Ciberseguridad         ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Conversor de Unidades (Secuencial)");
                Console.WriteLine("2. Sistema de Nómina y Deducciones (AFP/SFS)");
                Console.WriteLine("3. Evaluador de Notas con Decisiones (if/switch)");
                Console.WriteLine("4. Tabla de Multiplicar Validada (Ciclos)");
                Console.WriteLine("0. Salir del Sistema");
                Console.Write("Seleccione una opción del módulo integrador: ");

                opcionPrincipal = Console.ReadLine();

                switch (opcionPrincipal)
                {
                    case "1":
                        ModuloConversor();
                        break;
                    case "2":
                        ModuloNomina();
                        break;
                    case "3":
                        ModuloCalificaciones();
                        break;
                    case "4":
                        ModuloTablas();
                        break;
                    case "0":
                        Console.WriteLine("\nSaliendo del Proyecto Final. ¡Gracias por usar el sistema!");
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }

            } while (opcionPrincipal != "0");
        }

        // Módulo 1: Conversor Secuencial
        static void ModuloConversor()
        {
            Console.Clear();
            Console.WriteLine("--- MÓDULO 1: CONVERSOR DE UNIDADES ---");
            const double LIBRAS_A_KG = 0.453592;

            Console.Write("Ingrese peso en libras (lb): ");
            if (double.TryParse(Console.ReadLine(), out double lb))
            {
                double kg = lb * LIBRAS_A_KG;
                Console.WriteLine($"Resultado: {lb:F2} lb equivalen a {kg:F2} kg.");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        // Módulo 2: Nómina
        static void ModuloNomina()
        {
            Console.Clear();
            Console.WriteLine("--- MÓDULO 2: CÁLCULO DE NÓMINA ---");
            const double AFP = 0.0287;
            const double SFS = 0.0304;

            Console.Write("Ingrese horas trabajadas: ");
            double horas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese pago por hora: ");
            double pago = Convert.ToDouble(Console.ReadLine());

            double bruto = horas * pago;
            double descAfp = bruto * AFP;
            double descSfs = bruto * SFS;
            double neto = bruto - (descAfp + descSfs);

            Console.WriteLine($"Salario Bruto: RD$ {bruto:N2}");
            Console.WriteLine($"Descuento AFP: RD$ {descAfp:N2}");
            Console.WriteLine($"Descuento SFS: RD$ {descSfs:N2}");
            Console.WriteLine($"Salario Neto: RD$ {neto:N2}");

            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        // Módulo 3: Calificaciones
        static void ModuloCalificaciones()
        {
            Console.Clear();
            Console.WriteLine("--- MÓDULO 3: EVALUADOR DE NOTAS ---");
            Console.Write("Ingrese una nota (0 - 100): ");
            if (int.TryParse(Console.ReadLine(), out int nota) && nota >= 0 && nota <= 100)
            {
                string letra = nota >= 90 ? "A" : nota >= 80 ? "B" : nota >= 70 ? "C" : "F";
                Console.WriteLine($"Calificación literal: [{letra}]");
            }
            else
            {
                Console.WriteLine("Nota fuera de rango o inválida.");
            }
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        // Módulo 4: Tablas con Ciclos
        static void ModuloTablas()
        {
            Console.Clear();
            Console.WriteLine("--- MÓDULO 4: TABLA DE MULTIPLICAR ---");
            Console.Write("Ingrese un número entre 1 y 12: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 12)
            {
                int i = 1;
                int suma = 0;
                while (i <= 12)
                {
                    int res = num * i;
                    Console.WriteLine($"{num} x {i} = {res}");
                    suma += res;
                    i++;
                }
                Console.WriteLine($"Suma total de resultados: {suma}");
            }
            else
            {
                Console.WriteLine("Número fuera del rango permitído (1-12).");
            }
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}