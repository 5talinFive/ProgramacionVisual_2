using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
    public class Producto
    {
        //Propiedades producto
        public int ProductoId { get; set; }
        public int Stock { get; set; }
        public string Modelo { get; set; }

        public Tipo Tipo { get; set; }
        public int TipoId { get; set; }
        //relacion con provedores
        public Proveedores Proveedores { get; set; }
        public int ProvedoresId { get; set; }
        //relacion con moviiento  
        public List<Movimientos> Movimiento { get; set; }
        //pedidio 
        public List<Pedido> Pedido { get; set; }
        public int PedidoId { get; set; }
    }
}
