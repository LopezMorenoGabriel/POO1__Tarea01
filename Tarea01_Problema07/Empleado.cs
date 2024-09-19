using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema07
{
    internal class Empleado
    {
        public Empleado(int codigo, string nombre, int nroCelular, double sueldo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.nroCelular = nroCelular;
            this.sueldo = sueldo;
        }

        public int codigo { get; set; }
        public string nombre { get; set; }
        public int nroCelular { get; set; }
        public double sueldo { get; set; }

        /*Un método que retorne un texto indicando si el sueldo es “mayor a 3500”, “menor a 3500” o
        “igual a 3500”.*/
        public string determinarSueldo() 
        {
            if (sueldo > 3500)
            {
                return "mayor a 3500";
            }
            else if (sueldo < 3500)
            {
                return "menor a 3500";
            }
            else 
            {
                return "igual a 3500";
            }
        }
    }
}
