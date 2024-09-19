using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_semana1
{
    internal class Docente
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horas { get; set; }
        public double tarifa { get; set; }

        public double calcularSueldoBruto()
        {
            return horas * tarifa;
        }

        public double descuentoSueldo()

        {
            double sueldo = calcularSueldoBruto();

            if (sueldo < 4500) 
            { 
                return sueldo * 0.12;
            }
            else if (sueldo >= 4500 && sueldo < 6500) 
            { 
                return sueldo * 0.14; 
            }
            else 
            { 
                return sueldo * 0.16; 
            }
        }
        public double calcularSueldoNeto()
        {
            return calcularSueldoBruto() - descuentoSueldo();
        }
    }
}
