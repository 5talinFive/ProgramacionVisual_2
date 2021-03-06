using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
    public class Movimientos
    {
        //Propiedades Movimientos
        public int MovimientoId { get; set; }
        public string Estado { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double Cantidad { get; set; }

        //Relacion con productos 
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }
    }
}
