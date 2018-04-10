using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arriendo
    {
        int valor;
        Cliente clientes;
        Vehiculo Vehiculo;
        Sucursales sucursal;
        DateTime inicio;
        DateTime final;
        List<accesorios> accesorios;

        public Arriendo(int valor, Cliente clientes, Vehiculo vehiculo, Sucursales sucursal, DateTime inicio, DateTime final)
        {
            this.valor = valor;
            this.clientes = clientes;
            Vehiculo = vehiculo;
            this.sucursal = sucursal;
            this.inicio = inicio;
            this.final = final;
            accesorios = new List<accesorios>();
        }
    }
}