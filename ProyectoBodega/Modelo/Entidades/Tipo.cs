using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
    public class Tipo
    {
        public int TipoId { get; set; }

        public string Nombre { get; set; }
        //relacion con productos
        public List<Producto> Productos { get; set; }
    }
}
