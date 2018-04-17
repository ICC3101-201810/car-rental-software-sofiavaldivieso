using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_POO
{
    class Sucursales
    {
        string nombre, ubicacion;
        public List<Accesorios> accesorios;
        public List<Cliente> cliente;
        public List<Vehiculo> vehiculo;

        public Sucursales(string nombre, string ubicacion)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            accesorios = new List<Accesorios>();
            cliente = new List<Cliente>();
            vehiculo = new List<Vehiculo>();
        }

        public void arrendar1(Sucursales sucursales, Accesorios accesorios, Cliente cliente, Vehiculo vehiculo, DateTime inicio, DateTime final)
        {
            int valor = accesorios.precio + vehiculo.precio;
            Arriendo arrendado = new Arriendo(valor, cliente, vehiculo, sucursales, inicio, final);
            accesorios.stock = accesorios.stock - 1;
            vehiculo.stock--;
        }
        public void arrendar(Sucursales sucursales, Cliente cliente, Vehiculo vehiculo, DateTime inicio, DateTime final)
        {
            int valor = vehiculo.precio;
            Arriendo arrendado = new Arriendo(valor, cliente, vehiculo, sucursales, inicio, final);
            vehiculo.stock--;

        }
    }
}
