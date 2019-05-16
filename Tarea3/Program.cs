using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuisMoreira3C.Clases;


namespace LuisMoreira3C
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente Cliente1 = new Cliente();
            Cliente1.DatosClientes();

            Gasolina VentaGasolina1 = new Gasolina();
            VentaGasolina1.DatosGasolina();

           
            Console.WriteLine("\n\n_______________TERCER NIVEL CÍA. LDTA_________________\n");
            Console.WriteLine("\nDATOS DEL CLIENTE: ");
            Console.WriteLine("Nombres: " + Cliente1.Nombres);
            Console.WriteLine("Apellidos: " + Cliente1.Apellidos);
            Console.WriteLine("Número de cédula: " + Cliente1.NumeroDeCedula);
            Console.WriteLine("Direccion: " + Cliente1.Direccion);
            Console.WriteLine("\nDATOS GASOLINA: ");
            Console.WriteLine("Tipo de Gasolina: "+VentaGasolina1.Tipo);
            Console.WriteLine("Cantidad de Galones:  "+VentaGasolina1.CantidadDeGalones);

            VentaGasolina1.CalculoPrecios();
            VentaGasolina1.mostrar();




            Console.ReadKey();
        }
    }
}
