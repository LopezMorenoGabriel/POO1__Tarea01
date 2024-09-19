using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Poblema01
{
    internal class Celular
    {
        public Celular(int numero, string usuario, int segConsumidos, double precioXsegundo)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segConsumidos = segConsumidos;
            this.precioXsegundo = precioXsegundo;
        }

        public int  numero { get; set; }
        public string usuario { get; set; }
        public int segConsumidos  { get; set; }
        public double precioXsegundo { get; set; }

        //Un método que retorne el costo por consumo(segundos* precio).
        public double costoConsumo()
        {
            return precioXsegundo * segConsumidos;
        }

        //Un método que retorne el impuesto por IGV(18% del costo por consumo).
        public double impuestoIGV()
        {
            return costoConsumo() * 0.18;
        }

        //Un método que retorne el total a pagar(costo por consumo + impuesto por IGV)
        public double importeTotal()
        { 
            return costoConsumo() + impuestoIGV();
        }
    }
}
