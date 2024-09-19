using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Poblema02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Problema 02------");

            Computadora c = new Computadora(1111, "Halion", "negro",350);

            Console.WriteLine("Codigo del producto : " + c.codigo);
            Console.WriteLine("Marca : " + c.marca);
            Console.WriteLine("Color : " + c.color);
            Console.WriteLine("Precio(Dolares) : " + c.preDolar);
            Console.WriteLine("**************************************");
            Console.WriteLine("Precio(Soles) : " + c.precioSoles());
            Console.WriteLine("Precio(Euros) : " + c.precioEuro());

            Console.ReadKey();

        }
    }
}
