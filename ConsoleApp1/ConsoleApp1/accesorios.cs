using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class accesorios
    {
        public int stock;
        string tipoaccesorio;
        public int precio;

        public accesorios(string tipoaccesorio, int precio, int stock )
        {
            this.tipoaccesorio = tipoaccesorio;
            this.precio = precio;
            this.stock = stock;
        }
    }
}