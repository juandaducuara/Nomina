using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    internal class Empleado
    {
        private string DocumentoID;
        private string Nombres;
        private string Apellidos;
        private double Salario;
        private double Dias_Trabajados;
        private double TotalDevengado;
        private double AuxTransporte;
        private double Salud;
        private double Pensiones;

        public Empleado()
        {

        }

        public string DocumentoID1 { get => DocumentoID; set => DocumentoID = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public double Salario1 { get => Salario; set => Salario = value; }
        public double Dias_Trabajados1 { get => Dias_Trabajados; set => Dias_Trabajados = value; }
        public double TotalDevengado1 { get => TotalDevengado; set => TotalDevengado = value; }
        public double AuxTransporte1 { get => AuxTransporte; set => AuxTransporte = value; }
        public double Salud1 { get => Salud; set => Salud = value; }
        public double Pensiones1 { get => Pensiones; set => Pensiones = value; }
    }
}
