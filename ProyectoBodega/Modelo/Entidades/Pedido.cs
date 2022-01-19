using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime FechaPedida { get; set; }
        public DateTime FechaFin { get; set; }
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }
    }
}
