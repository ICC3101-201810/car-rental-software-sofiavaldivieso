using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_POO
{
    public class terrestre : Vehiculo
    {
        
        String tipo_auto;
        string marca;
        int año;
        string modelo;
        int precio;
        int stock;

        public terrestre( string tipo_auto, string marca, int año, string modelo, int precio, int stock): base(marca, año, modelo, precio, stock)
        {
            this.precio = precio;
            this.stock = stock;
            this.tipo_auto = tipo_auto;
            this.marca = marca;
            this.año = año;
            this.modelo = modelo;

        }
        public void info()
        {
            Console.WriteLine("tipo de auto:" + tipo_auto + "marca" + marca + "año" + año + "modelo" + modelo + "precio" + precio)
        }
    }
}
