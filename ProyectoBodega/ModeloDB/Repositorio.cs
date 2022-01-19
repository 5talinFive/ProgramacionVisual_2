using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class Repositorio: DbContext
    {
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Bodega> Bodega { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }
        public DbSet<Movimientos> Movimientos { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Tipo> Tipo { get; set; }


        //Configuracion de la conexion
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=MIPCC\\STALINSQL; Initial Catalog=Bodega; trusted_connecion=true;");
        }

    }
}
