using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Domain
{
    internal abstract class Empleado : Persona
    {
        
        //private Areas libreDueda;

        
        //    this.libreDueda = libreDueda;
        //}

        public Empleado(string nombreCompleto, string domicilio, string celular,  long legajo,Areas area): base( nombreCompleto, domicilio , celular)
        {
            Legajo = legajo;
            Area = area;

        }

        public long Legajo { get; private set; }

        public DateTime FechaAlta { get; private set; }

        public Areas Area { get; private set; }

        public abstract long CalculoSueldo();

        


    }
}
