using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    class Repositorio: DbContext
    {
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Bodega> Bodega { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }
        public DbSet<Movimientos> Movimientos { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
    }
}
