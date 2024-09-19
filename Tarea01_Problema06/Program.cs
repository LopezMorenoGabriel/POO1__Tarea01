using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Problema 06------");

            Paciente p = new Paciente("Gabriel", "Lopez", 20, 1.68,64);

            Console.WriteLine("Nombre : " + p.nombre);
            Console.WriteLine("Apellido : " + p.apellido);
            Console.WriteLine("Edad : " + p.edad);
            Console.WriteLine("Talla : " + p.talla + "m");
            Console.WriteLine("Peso : " + p.peso + " kg");
            Console.WriteLine("Estado : " + p.determinarEdad());

            Console.ReadKey();
        }
    }
}
