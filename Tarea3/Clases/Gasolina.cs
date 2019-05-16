using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisMoreira3C.Clases
{
    public class Gasolina
    {
        private int tipo;

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int cantidadDeGalones;

        public int CantidadDeGalones
        {
            get { return cantidadDeGalones; }
            set { cantidadDeGalones = value; }
        }

        

        public void DatosGasolina()
        {
            Console.WriteLine("\n****INGRESE DATOS DE LA COMPRA DE GASOLINA****");
            Console.WriteLine("\nTIPO DE GASOLINA (Extra:1 , Super:2 ):");
            tipo = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCANTIDAD DE GALONES:");
            cantidadDeGalones = int.Parse(Console.ReadLine());
        }

        private double Total=0.0;
        private double Iva=0.12;
        private double Subtotal=0.0;

        public void CalculoPrecios()
        {
            if (tipo == 1)
            {
                Subtotal = 1.50 * cantidadDeGalones;
            }
            else
            {
                if (tipo == 2)
                {
                    Subtotal = 2.00 * cantidadDeGalones;
                }
            }

            Iva = Subtotal * 0.12;
            Total = Iva + Subtotal;

        }

        public void mostrar()
        {
            Console.WriteLine("\nVALOR A CANCELAR: ");    
            Console.WriteLine("Subtotal: " + Subtotal);
            Console.WriteLine("Iva: " + Iva);
            Console.WriteLine("Total: " + Total);
        }



    }

    
}
