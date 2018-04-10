using System;
namespace ConsoleApp1
{
    public class terrestre : Vehiculo
    {
        
        String tipo_auto;
        string marca;
        int año;
        string modelo;
        int precio;

        public terrestre( string tipo_auto, string marca, int año, string modelo, int precio): base(marca, año, modelo, precio)
        {
            this.precio = precio;
            this.tipo_auto = tipo_auto;
            this.marca = marca;
            this.año = año;
            this.modelo = modelo;
        }
    }
}
