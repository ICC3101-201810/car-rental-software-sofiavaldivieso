using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_POO
{
    public class Accesorios
    {
        public int stock;
        string tipoaccesorio;
        public int precio;

        public Accesorios(string tipoaccesorio, int precio, int stock)
        {
            this.tipoaccesorio = tipoaccesorio;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
