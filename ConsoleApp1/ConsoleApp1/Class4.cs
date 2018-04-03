using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arriendo
    {
        Cliente cliente;
        Vehiculo Vehiculo;
        Sucursales sucursal;
        DateTime fecha_inicio;
        accesorios accesorios;

        public Arriendo(Cliente cliente, Vehiculo vehiculo, Sucursales sucursal, DateTime fecha_inicio, accesorios accesorios)
        {
            this.cliente = cliente;
            Vehiculo = vehiculo;
            this.sucursal = sucursal;
            this.fecha_inicio = fecha_inicio;
            this.accesorios = accesorios;
        }


    }
}
