using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Problema 03------");

            Edificio e = new Edificio(1111,16,32,3500);

            Console.WriteLine("Codigo : " + e.codigo);
            Console.WriteLine("Cantidad de departamentos : " + e.nroDepartamentos);
            Console.WriteLine("Cantidad de pisos : " + e.cantPisos);
            Console.WriteLine("Precio de departamentos(Dolares) : " + e.preDepartamento);
            Console.WriteLine("**************************************");
            Console.WriteLine("Precio del Edificio : " + e.precioDolaresEdificio());

            Console.ReadKey();
        }
    }
}
