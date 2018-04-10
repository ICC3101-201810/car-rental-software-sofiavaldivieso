using System;
namespace ConsoleApp1
{
    public class Empresa: Cliente
    {
        string nombre_empresa;
        string Licencia_empresa;
        string solicitud_empresa;
        string organizacion;
        string institucion;


        public Empresa(string nombre_empresa, string licencia_empresa,string solicitud_empresa, string organizacion, string institucion) : base( organizacion, institucion)
        {
            this.nombre_empresa = nombre_empresa;
            Licencia_empresa = licencia_empresa;
            this.solicitud_empresa = solicitud_empresa;
            this.organizacion = organizacion;
            this.institucion = institucion;
        }

        public bool chek_Licencia_empresa(Empresa empresa)
        {
            if (empresa.Licencia_empresa == solicitud_empresa)
            {
                return true;
            }
            return false;
        }

        public void chek_maquinariapesada(Empresa empresa)
        {
            if (empresa.Licencia_empresa=="maquinariapesada pesada")
            {
                Console.WriteLine("entregar permisos");
            }
        }
    }
}
