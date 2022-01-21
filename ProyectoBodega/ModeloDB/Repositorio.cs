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
            model.Entity<Producto>().HasOne(prod => prod.Proveedores);
            model.Entity<Producto>().HasOne(prod => prod.Tipo);
            model.Entity<Producto>()
                .HasOne(prod => prod.Tipo)
                .WithMany(almacen => almacen.Productos)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(prod => prod.Movimiento);

            //Configuracion de Pedido
            model.Entity<Pedido>().HasOne(pedido => pedido.Producto);
            model.Entity<Pedido>()
                 .HasOne(pedido => pedido.Producto)
                 .WithMany(movimientos => movimientos.Pedido)
                 .OnDelete(DeleteBehavior.Cascade)
                 .HasForeignKey(pedido => pedido.PedidoId);
        }

    }
}
