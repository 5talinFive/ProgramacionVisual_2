using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
    public class Proveedores
    {
        //Propiedades proveedores
        public int ProvedoresId { get; set; }
        public string Nombre { get; set; }
        public DateTime Plazodeentrega { get; set; }
        public double Cantidadminima { get; set; }
    }
}
