using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Domain
{
    internal class EmpleadoPorHora :Empleado
    {
        public long HorasTrabajadas { get; set; }
        public  long ValorHora { get; set; }

        public EmpleadoPorHora(string nombreCompleto, string domicilio, string celular, long legajo, Areas area ,long horas, long valorHora)
        : base(nombreCompleto, domicilio, celular, legajo ,area)
        {
            HorasTrabajadas = horas;
            ValorHora = valorHora;
        }

        public override long CalculoSueldo()
        {
            return HorasTrabajadas * ValorHora;
        }
    }
}
