using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_semana1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Tarea 01------------------");

            Docente doc = new Docente();
            doc.nombre = "Gabriel";
            doc.tarifa = 2000;
            doc.horas = 4;
            doc.codigo = 3216;

            imprimir("Codigo : " + doc.codigo);
            imprimir("Sueldo bruto : " + doc.calcularSueldoBruto());
            imprimir("Descuento : " + doc.descuentoSueldo());
            imprimir("Sueldo neto : " + doc.calcularSueldoNeto());

            Console.ReadKey();
        }
        public static void imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
