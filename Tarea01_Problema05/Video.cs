using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema05
{
    internal class Video
    {
        public Video(int codigo, string nombre, double duracion, double precio, double tipoCambio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.duracion = duracion;
            this.precio = precio;
            this.tipoCambio = tipoCambio;
        }

        public int codigo { get; set; }
        public string nombre { get; set; }
        public double duracion { get; set; }
        public double precio { get; set; }
        public double tipoCambio { get; set; }

        //Un método que retorne el precio del video en dólares.
        public double precioDolares()
        {
            return precio / tipoCambio;
        }
    }
}
