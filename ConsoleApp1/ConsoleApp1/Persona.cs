using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona : Vehiculo
    {
        String tipo_auto;
        String licencia_conducir;
        String vehiculo_licencia;

        public Persona(string tipo_auto, string licencia_conducir, string vehiculo_licencia) : base(tipo_auto)
        {
            this.tipo_auto = tipo_auto;
            this.Licencia_conducir = licencia_conducir;
            this.vehiculo_licencia = vehiculo_licencia;
        }

        public string Licencia_conducir
        {
            get => licencia_conducir;
            set
            {
                if (vehiculo_licencia == tipo_auto)
                {
                    licencia_conducir = tipo_auto;
                }
            }
        }
    }
}
