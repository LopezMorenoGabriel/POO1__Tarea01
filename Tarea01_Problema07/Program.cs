using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Problema 07------");

            Empleado e = new Empleado(1111, "Antonio", 987654321, 3400);

            Console.WriteLine("Codigo : " + e.codigo);
            Console.WriteLine("Nombre : " + e.nombre);
            Console.WriteLine("Número de celular : " + e.nroCelular);
            Console.WriteLine("Sueldo : " + e.sueldo);
            Console.WriteLine("El sueldo es " + e.determinarSueldo());

            Console.ReadKey();
        }
    }
}
