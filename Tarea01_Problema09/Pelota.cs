using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Problema09
{
    internal class Pelota
    {
        public Pelota(string marca, double peso, double presion, double diametro, double precio)
        {
            this.marca = marca;
            this.peso = peso;
            this.presion = presion;
            this.diametro = diametro;
            this.precio = precio;
        }

        public string marca {  get; set; }
        public double peso { get; set; }
        public double presion { get; set; }
        public double diametro { get; set; }
        public double precio { get; set; }

        //Un método que retorne el radio(diámetro / 2).
        public double determinarRadio() 
        {
            return diametro / 2;
        }
        //Un método que retorne el volumen del balón(4 * 3.1416 * radio* radio * radio / 3).
        public double volPelota()
        {
            return (4 * 3.1416 * determinarRadio() * determinarRadio() * determinarRadio()) / 3;
        }
        //Un método que retorne el descuento(10% del precio).
        public double descuento()
        {
            return precio * 0.10;
        }
        //Un método que retorne el importe a pagar(precio - descuento)
        public double impPagar() 
        { 
            return precio - descuento();
        }
    }
}
