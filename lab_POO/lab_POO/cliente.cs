using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_POO
{
    class Cliente
    {
        string rut;
        string organizacion;
        string institucion;
        int stock;

        public Cliente(string organizacion, string institucion, string rut)
        {
            this.rut = rut;
            this.organizacion = organizacion;
            this.institucion = institucion;

        }
    }
}
