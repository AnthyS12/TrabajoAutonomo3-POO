using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisMoreira3C.Clases
{
    public class Cliente
    {
        private string nombres ;

        public string Nombres
        {
            get { return nombres ; }
            set { nombres  = value; }
        }

        private string apellidos;

        public  string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private int numeroDeCedula;

        public int NumeroDeCedula
        {
            get { return numeroDeCedula; }
            set { numeroDeCedula = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public void DatosClientes()
        {
            Console.WriteLine(" \n****INGRESAR DATOS DEL CLIENTE**** ");
            Console.WriteLine("\nNOMBRES: ");
            nombres = Console.ReadLine();
            Console.WriteLine("\nAPELLIDOS: ");
            apellidos = Console.ReadLine();
            Console.WriteLine("\nNÚMERO DE CÉDULA: ");
            numeroDeCedula = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDIRECCIÓN: ");
            direccion = Console.ReadLine();
        }


    }
}
