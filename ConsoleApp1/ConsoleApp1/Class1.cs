using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente : Persona
    {
        string licencia_conducir;
        string vehiculo_licencia;
        string empresa;
        string organizacion;
        string institucion;
        public Cliente(string licencia_conducir, string vehiculo_licencia, string empresa, string organizacion, string institucion) : base(licencia_conducir, vehiculo_licencia)
        {
            this.licencia_conducir = licencia_conducir;
            this.vehiculo_licencia = vehiculo_licencia;
            this.empresa = empresa;
            this.organizacion = organizacion;
            this.institucion = institucion;
        }



    }
}
