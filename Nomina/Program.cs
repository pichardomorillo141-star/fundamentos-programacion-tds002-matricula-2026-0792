/* 
 * Nombre: Alex Rafael Pichardo Morillo
 * Matrícula: 2026-0792
 * Carrera: Tecnólogo en Ciberseguridad
 * Descripción: Programa 1 de la Evaluación 03 - Cálculo de nómina con deducciones de ley (AFP y SFS).
 */

using System;

namespace Nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de constantes para los porcentajes de deducción
            const double PORCENTAJE_AFP = 0.0287; // 2.87%
            const double PORCENTAJE_SFS = 0.0304; // 3.04%

            string nombreEmpleado;
            double horasTrabajadas, pagoPorHora;

            Console.WriteLine("========================================");
            Console.WriteLine("       SISTEMA DE CÁLCULO DE NÓMINA     ");
            Console.WriteLine("========================================");

            // Entrada de datos
            Console.Write("Ingrese el nombre del empleado: ");
            nombreEmpleado = Console.ReadLine();

            Console.Write("Ingrese las horas trabajadas: ");
            horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el pago por hora: ");
            pagoPorHora = Convert.ToDouble(Console.ReadLine());

            // Procesos
            double salarioBruto = horasTrabajadas * pagoPorHora;
            double montoAfp = salarioBruto * PORCENTAJE_AFP;
            double montoSfs = salarioBruto * PORCENTAJE_SFS;
            double totalDeducciones = montoAfp + montoSfs;
            double salarioNeto = salarioBruto - totalDeducciones;

            // Salida de resultados (Nombre en MAYÚSCULAS y montos con formato N2)
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("             RESUMEN DE PAGO            ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Empleado: {nombreEmpleado.ToUpper()}");
            Console.WriteLine($"Salario Bruto: RD$ {salarioBruto:N2}");
            Console.WriteLine($"Descuento AFP (2.87%): RD$ {montoAfp:N2}");
            Console.WriteLine($"Descuento SFS (3.04%): RD$ {montoSfs:N2}");
            Console.WriteLine($"Salario Neto: RD$ {salarioNeto:N2}");
            Console.WriteLine("========================================");
        }
    }
}