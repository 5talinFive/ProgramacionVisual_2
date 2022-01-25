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
            options.UseSqlServer("Server=MIPCC\\STALINSQL; Initial Catalog=Bodega; trusted_connection=true;");

        }

        //Configurar el modelo de Objetos
        protected override void OnModelCreating(ModelBuilder model)
        {
            //Configuracion de Producto
            model.Entity<Producto>().HasOne(Prod => Prod.Proveedores);
            model.Entity<Producto>().HasOne(Prod => Prod.Tipo);
            model.Entity<Producto>()
                .HasOne(Prod => Prod.Tipo)
                .WithMany(Bodega => Bodega.Productos)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(Prod => Prod.Movimiento);

            //Configuracion de Pedido
            model.Entity<Pedido>().HasOne(Pedido => Pedido.Producto);
            model.Entity<Pedido>()
                 .HasOne(Pedido => Pedido.Producto)
                 .WithMany(Movimientos => Movimientos.Pedido)
                 .OnDelete(DeleteBehavior.Cascade)
                 .HasForeignKey(Pedido => Pedido.PedidoId);
        }

    }
}
