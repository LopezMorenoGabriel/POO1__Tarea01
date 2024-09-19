using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema06
{
    internal class Paciente
    {
        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        public string nombre {  get; set; }
        public string apellido { get; set; }
        public int edad {  get; set; }
        public double talla { get; set; }
        public double peso { get; set; }

        //Un método que retorne el texto: “menor de edad” o “mayor de edad”
        public string determinarEdad()
        {
            return edad < 18 ? "menor de edad" : "mayor de edad";
        }
    }
}
