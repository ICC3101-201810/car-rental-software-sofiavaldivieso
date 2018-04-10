using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sucursales
    {
        string nombre, ubicacion;
        List<accesorios> accesorios;
        List<Cliente> cliente;
        List<Vehiculo> vehiculo;

        public Sucursales(string nombre, string ubicacion)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            accesorios = new List<accesorios>();
            cliente = new List<Cliente>();
            vehiculo = new List<Vehiculo>();
        }

        public void arrendar(Sucursales sucursales, accesorios accesorios, Cliente cliente, Vehiculo vehiculo, DateTime inicio, DateTime final)
        {
            int valor = accesorios.precio + vehiculo.precio;
            Arriendo arrendado = new Arriendo(valor, cliente, vehiculo, sucursales, inicio, final);
            accesorios.stock = accesorios.stock - 1;

        }
        public void arrendar(Sucursales sucursales, Cliente cliente, Vehiculo vehiculo, DateTime inicio, DateTime final)
        {
            int valor = vehiculo.precio;
            Arriendo arrendado = new Arriendo(valor, cliente, vehiculo, sucursales, inicio, final);

        }
    }

}