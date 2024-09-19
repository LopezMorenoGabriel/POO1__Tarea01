using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Problema 09------");

            Pelota p = new Pelota("Nike", 500, 8.5, 22, 150);

            Console.WriteLine("Marca : " + p.marca);
            Console.WriteLine("Peso en gramos : " + p.peso);
            Console.WriteLine("Presión en libras : " + p.presion);
            Console.WriteLine("Diámetro en cm : " + p.diametro);
            Console.WriteLine("Precio : " + p.precio);
            Console.WriteLine("**************************************");
            Console.WriteLine("Radio : " + p.determinarRadio());
            Console.WriteLine("Volumen : " + p.volPelota());
            Console.WriteLine("Descuento : " + p.descuento());
            Console.WriteLine("Importe a pagar : " + p.impPagar());

            Console.ReadKey();
        }
    }
}
