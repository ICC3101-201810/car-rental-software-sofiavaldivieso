using System;

namespace ConsoleApp1
{
    class ConsoleApp1
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. crear sucursal");
                Console.WriteLine("2. agregar accesorios");
                Console.WriteLine("3. agregar clientes");
                Console.WriteLine("4. agregar vehiculos");
                Console.WriteLine("5. terminar");
                string x = Console.ReadLine();
                if (x== "1")
                {
                    nombre= Console.ReadLine();
                    ubicacion=Console.ReadLine();
                    sucursal1= new Sucursales(nombre, ubicacion);
                }
                if (x=="2")
                {
                    Console.WriteLine("ingrese stock, precio y tipo");
                    int stock1= Console.ReadLine();
                    int precio1= Console.ReadLine();
                    int stock1= Console.ReadLine();
                    accesorio1= new accesorios( tipo1, precio1, stock1);
                    sucursal1.accesorios.Add(accesorio1);
                }
                if (x=="3")
                {
                    Console.WriteLine("ingrese datos cliente");
                    string rut1= Console.ReadLine();
                    string organizacion1= Console.ReadLine();
                    string institucion1= Console.ReadLine();
                    cliente1= new Cliente(organizacion1, institucion1,rut1);
                    sucursal1.clientes.Add(cliente1);
                }
                if (x=="4")
                {
                    Console.WriteLine("ingrese datos vehiculo");
                    string marca1= Console.ReadLine();
                    int año1= Console.ReadLine();
                    string modelo1= Console.ReadLine();
                    int precio1= Console.ReadLine();
                    vehiculo1= new Vehiculo(marca1, año1,modelo1, precio1);
                    sucursal1.vehiculo.Add(cliente1);
                }
                if (x==5)
                {
                    break;
                }
            }
            Console.WriteLine("agregar arriendo? 1. si, 2. no");
            string x = Console.ReadLine();
            if (x=="1")
            {
                Console.WriteLine("ingrese datos cliente");
                string rut1= Console.ReadLine();
                string organizacion1= Console.ReadLine();
                string institucion1= Console.ReadLine();
                cliente1= new Cliente(organizacion1, institucion1,rut1);
                
            }




        }
    }
}
