using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Domain
{
    internal class EmpleadoFijo : Empleado
    {

        public long SueldoMensual { get; set; }

        public EmpleadoFijo(string nombreCompleto, string domicilio, string celular, long legajo, Areas area, long sueldoMensual)
       : base(nombreCompleto, domicilio, celular, legajo, area)
        {
            SueldoMensual = sueldoMensual;
        }

        public override long CalculoSueldo()
        {
            return SueldoMensual;
        }
    }
}
