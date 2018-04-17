using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_POO
{
    public abstract class Vehiculo
    {
        string marca;
        int año;
        string modelo;
        public int precio;
        public int stock;

        public Vehiculo(string marca, int año, string modelo, int precio, int stock)
        {
            this.marca = marca;
            this.año = año;
            this.modelo = modelo;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
