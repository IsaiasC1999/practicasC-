using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    internal abstract class Persona
    {

        public string NombreCompleto { get; set; } = string.Empty;

        public DateTime Fecha_Nacimiento { get; private set; }

        public string Domicilio { get; set; }

        public string Celular { get; set; }

        public Persona(string nombreCompleto, string domicilio, string celular)
        {
            NombreCompleto = nombreCompleto;
            Domicilio = domicilio;
            Celular = celular;
            Fecha_Nacimiento = DateTime.Now;

        }

        

    }
}
