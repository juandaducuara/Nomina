using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    internal class Pagos
    {
        Empleado miEmpleado = new Empleado();
        public void CalcularNomina()
        {
            try
            {
                Console.WriteLine("Digite la cedula del empleado");
                miEmpleado.DocumentoID1 = Console.ReadLine();
                Console.WriteLine("Digite el nombre del empleado");
                miEmpleado.Nombres1 = Console.ReadLine();
                Console.WriteLine("Digite el apellido del empleado");
                miEmpleado.Apellidos1 = Console.ReadLine();
                Console.WriteLine("Digite el salario del empleado");
                miEmpleado.Salario1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite dias trabajados del empleado");
                miEmpleado.Dias_Trabajados1 = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }

            miEmpleado.TotalDevengado1 = miEmpleado.Salario1 / 30;
            miEmpleado.TotalDevengado1 = miEmpleado.TotalDevengado1 * miEmpleado.Dias_Trabajados1;


            miEmpleado.AuxTransporte1 = 117172 / 30;
            miEmpleado.AuxTransporte1 = miEmpleado.AuxTransporte1 * miEmpleado.Dias_Trabajados1;

            miEmpleado.Salud1 = miEmpleado.TotalDevengado1 * 0.04;
            miEmpleado.Pensiones1 = miEmpleado.TotalDevengado1 * 0.04;

            if (miEmpleado.Salario1<=2000000)
            {
                miEmpleado.TotalDevengado1 = miEmpleado.TotalDevengado1 + miEmpleado.AuxTransporte1;
            }
            else
            {
                miEmpleado.TotalDevengado1 = miEmpleado.TotalDevengado1;
            }

        }
        public void ImprimirDatos()
        {
            Console.WriteLine($"Numero de cedula: {miEmpleado.DocumentoID1} ");
            Console.WriteLine($"Nombre: {miEmpleado.Nombres1}");
            Console.WriteLine($"Apellidos: {miEmpleado.Apellidos1}");
            Console.WriteLine($"Salario: {miEmpleado.Salario1}");
            Console.WriteLine($"Dias trabajados: {miEmpleado.Dias_Trabajados1}");
            Console.WriteLine($"Total devengado: {miEmpleado.TotalDevengado1}");
            Console.WriteLine($"Pago Salud: {miEmpleado.Salud1}");
            Console.WriteLine($"Pago Pensiones: {miEmpleado.Pensiones1}");

        }
    }
}
