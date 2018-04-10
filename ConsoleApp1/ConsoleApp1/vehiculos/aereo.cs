using System;
namespace ConsoleApp1
{
    public class Aereo: Vehiculo
    {
        int precio;
        String tipo_auto;
        string marca;
        int año;
        string modelo;

        public Aereo(string tipo_auto, string marca, int año, string modelo, int precio): base(marca, año, modelo, precio)
        {
            this.precio = precio;
            this.tipo_auto = tipo_auto;
            this.marca = marca;
            this.año = año;
            this.modelo = modelo;
        }
    }
}
