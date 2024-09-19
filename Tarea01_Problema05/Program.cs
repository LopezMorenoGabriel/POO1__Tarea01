using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Problema 05------");

            Video v = new Video(111, "Minecraft movie", 2.5, 50.0, 3.75);

            Console.WriteLine("Codigo : " + v.codigo);
            Console.WriteLine("Nombre : " + v.nombre);
            Console.WriteLine("Duracion : " + v.duracion);
            Console.WriteLine("Precio(Soles) : " + v.precio);
            Console.WriteLine("Precio(Dólares) : " + v.precioDolares());

            Console.ReadKey();

        }
    }
}
