using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Poblema02
{
    internal class Computadora
    {
        public Computadora(int codigo, string marca, string color, double preDolar)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.preDolar = preDolar;
        }

        public int codigo {  get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public double preDolar { get; set; }

        //Un método que retorne el precio de la computadora en soles(1 dólar = 3.35 soles).
        public double precioSoles()
        {
            return preDolar * 3.35;
        }
        //Un método que retorne el precio de la computadora en euros(1 euro = 1.20 dólares).
        public double precioEuro()
        {
            return preDolar / 1.20;
        }
    }
}
