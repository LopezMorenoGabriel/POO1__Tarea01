using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Problema 04------");

            Obrero o = new Obrero(1111,"Javier",32,60);

            Console.WriteLine("Codigo : " + o.codigo);
            Console.WriteLine("Nombre : " + o.nombre);
            Console.WriteLine("Horas trabajadas : " + o.horas);
            Console.WriteLine("Tarifa por hora : " + o.tarifa);
            Console.WriteLine("**************************************");
            Console.WriteLine("Sueldo bruto : " + o.sueldoBruto());
            Console.WriteLine("Descuento(AFP) : " + o.descAFP());
            Console.WriteLine("Descuento(EPS) : " + o.descEPS());
            Console.WriteLine("Sueldo neto : " + o.sueldoNeto());

            Console.ReadKey();
        }
    }
}
