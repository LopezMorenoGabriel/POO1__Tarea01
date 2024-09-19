using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema08
{
    internal class Asesor
    {
        public Asesor(int codigo, string nombre, int horas, double tarifa)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horas = horas;
            this.tarifa = tarifa;
        }

        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horas { get; set; }
        public double tarifa { get; set; }

        //Un método que retorne el sueldo bruto(horas* tarifa).
        public double sueldoBruto()
        {
            return horas * tarifa;
        }
        //Un método que retorne el descuento(15% del sueldo bruto).
        public double dscSueldo() 
        {
            return sueldoBruto() * 0.15;
        }
        //Un método que retorne el sueldo neto(sueldo bruto - descuento).
        public double sueldoNeto()
        {
            return sueldoBruto() - dscSueldo();
        }
    }
}
