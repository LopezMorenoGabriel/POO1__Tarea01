using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea01_Poblema01;

namespace Tarea01_Problema01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Problema 01------");

            Celular cel = new Celular(987654321,"Gabriel",1080,0.35);

            Console.WriteLine("Usuario : " + cel.usuario);
            Console.WriteLine("Número : " + cel.numero);
            Console.WriteLine("Segundos consumidos : " + cel.segConsumidos);
            Console.WriteLine("Costo por segundo : " + cel.precioXsegundo);
            Console.WriteLine("**************************************");
            Console.WriteLine("Costo por consumo : " + cel.costoConsumo());
            Console.WriteLine("Impuesto por IGV : " + cel.impuestoIGV());
            Console.WriteLine("Importe total : " + cel.importeTotal());


            Console.ReadKey();
        }
    }
}
