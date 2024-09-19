using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Problema 08------");

            Asesor a = new Asesor(1111,"Gabriel",40,60);

            Console.WriteLine("Codigo : " + a.codigo);
            Console.WriteLine("Nombre : " + a.nombre);
            Console.WriteLine("Horas trabajadas : " + a.horas);
            Console.WriteLine("Tarifa por hora : " + a.tarifa);
            Console.WriteLine("**************************************");
            Console.WriteLine("Sueldo bruto : " + a.sueldoBruto());
            Console.WriteLine("Descuento : " + a.dscSueldo());
            Console.WriteLine("Sueldo neto : " + a.sueldoNeto());

            Console.ReadKey();

        }
    }
}
