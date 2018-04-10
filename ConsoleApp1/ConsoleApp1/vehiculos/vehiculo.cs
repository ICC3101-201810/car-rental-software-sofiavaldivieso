using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Vehiculo
    {
        string marca;
        int año;
        string modelo;
        public int precio;

        public Vehiculo(string marca, int año, string modelo, int precio)
        {
            this.marca = marca;
            this.año = año;
            this.modelo = modelo;
            this.precio = precio;
        }
    }
}
