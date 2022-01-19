using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
    public class Bodega
    {
        //Propiedades de bodega
        public int BodegaId { get; set; }
        public string Nombre { get; set; }

        public Movimientos Movimientos { get; set; }
        public int MovimientoId { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
