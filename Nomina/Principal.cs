using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    internal class Principal
    {
        
        public static void Main(string[] args)
        {
            Pagos factura = new Pagos();
            Console.WriteLine("Bienvenido al programa de nomina");
            Console.WriteLine("1. Si desea agregar un empleado");
            Console.WriteLine("2. Si desea salir  del programa" );
            string opc = Console.ReadLine();
            int Opc1=1;
            switch (opc)
            {
                case "1":
                    do
                    {                   

                    factura.CalcularNomina();
                    factura.ImprimirDatos();
                    Console.WriteLine("1 Si desea agregar otro empleado");
                    Console.WriteLine("2 Si desea salir del programa");
                        
                            Opc1=int.Parse(Console.ReadLine());
                        
                        
                            Console.WriteLine("Dato no valido");
                            
                        
                    
                    Console.Clear();
                    } while (Opc1!=2);
                    break;
                case "2":
                    Console.WriteLine("Saliendo del programa");
                    break;
                default:
                    Console.WriteLine("Opcion no valida por favor digite otra opcion");
                    break;
            }

        }
    }
}
