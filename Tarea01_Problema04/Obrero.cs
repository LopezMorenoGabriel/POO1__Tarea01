using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema04
{
    internal class Obrero
    {
        public Obrero(int codigo, string nombre, int horas, double tarifa)
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
        //Un método que retorne el descuento por AFP(10% del sueldo bruto).
        public double descAFP() 
        {
            return sueldoBruto() * 0.10;
        }
        //Un método que retorne el descuento por EPS(5% del sueldo bruto).
        public double descEPS() 
        {
            return sueldoBruto() * 0.05;
        }
        //Un método que retorne el sueldo neto(sueldoBruto – descuentoAFP – descuentoEPS).
        public double sueldoNeto()
        { 
            return sueldoBruto() - descAFP() - descEPS();
        }
    }
}
