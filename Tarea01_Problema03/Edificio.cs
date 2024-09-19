using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema03
{
    internal class Edificio
    {
        public Edificio(int codigo, int nroDepartamentos, int cantPisos, double preDepartamento)
        {
            this.codigo = codigo;
            this.nroDepartamentos = nroDepartamentos;
            this.cantPisos = cantPisos;
            this.preDepartamento = preDepartamento;
        }

        public int codigo {  get; set; }
        public int nroDepartamentos { get; set; }
        public int cantPisos { get; set; }
        public double preDepartamento { get; set; }

        //Un método que retorne el precio en dólares del edificio(#dptos * precio de un dpto).
        public double precioDolaresEdificio()
        { 
            return nroDepartamentos * preDepartamento;
        }

    }
}
