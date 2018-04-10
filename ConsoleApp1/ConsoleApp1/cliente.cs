using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Cliente
    {
        string rut;
        string organizacion;
        string institucion;

        public Cliente( string organizacion, string institucion, string rut)
        {
            this.rut = rut;
            this.organizacion = organizacion;
            this.institucion = institucion;
        }


    }
}