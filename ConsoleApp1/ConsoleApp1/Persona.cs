using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona: Cliente
    {
        String licencia_conducir;
        String solicitud;
        string rut;
        string organizacion;
        string institucion;

        public Persona( string rut, string organizacion, string institucion, string licencia_conducir, String solicitud): base(rut, organizacion, institucion)
        {
            this.licencia_conducir = licencia_conducir;
            this.solicitud = solicitud;
            this.rut = rut;
            this.organizacion = organizacion;
            this.institucion = institucion;
        }

        public bool chek_Licencia_conducir(Persona persona)
        {
            if (persona.licencia_conducir == solicitud )
            {
                return true;
            }
            return false;
        }
    }
}
