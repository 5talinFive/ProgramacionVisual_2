using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Producto CamisaAdidas = new()
            {
                Modelo = "Adidas Turbo",
                Stock = 55

            };
            Producto PantalonTomy = new Producto() { Modelo = "Tomy Aero", Stock = 35 };

            List<Producto> listaProductos = new() { CamisaAdidas, CamisaAdidas };

            Pedido per2021_P2 = new()
            {

                FechaPedida = new DateTime(2020, 9, 1),
                FechaFin = new DateTime(2021, 3, 1)
            };
            Pedido per2021_P1 = new() { FechaPedida = new DateTime(2021, 4, 1), FechaFin = new DateTime(2021, 9, 1) };
            Pedido per2022_P2 = new() { FechaPedida = new DateTime(2021, 9, 1), FechaFin = new DateTime(2022, 3, 1) };
            List<Pedido> listaPedidos = new() { per2021_P2, per2021_P1, per2022_P2 };


            //Config datos de bodega
            Configuracion configuracion = new()
            {
                NombreBodega = "Bodega San Cristobal",
                valorminimo = 24,
            };
            List<Configuracion> listaConfiguracion = new() { configuracion };

            //Registro de Bodega
            Bodega estSanCristobal = new() { Nombre = "Bodega San Cristobal" };


            //Registro de Pendiente
            Movimientos Pendiente = new Movimientos()
            {
                TipoMovimiento = "Egreso",
                Estado = "Pendiente",
                FechaInicio = new DateTime(2021, 7, 25),
                FechaFin = new DateTime(2021, 7, 28),
                Cantidad = 6,
                Producto = PantalonTomy
            };

            Movimientos Ingreso = new Movimientos()
            {
                TipoMovimiento = "Ingreso",
                Estado = "Espera",
                FechaInicio = new DateTime(2021, 7, 28),
                FechaFin = new DateTime(2021, 8, 1),
                Cantidad = 6,
                Producto = CamisaAdidas

            };

            List<Movimientos> lstMovimiento = new()
            {
                Ingreso,
                Pendiente
            };

            

            Tipo Camisa = new Tipo()
            {
                Nombre = "CamisaAdidas"

            };
            List<Tipo> listamarca = new()
            {
                Camisa
            };
            

            Proveedores StalinSarango = new Proveedores()
            {
                Nombre = "Stalin Sarango",
                Cantidadminima = 34,
                Plazodeentrega = new DateTime(2021, 7, 26)


            };

            List<Proveedores> listaProvedores = new() { StalinSarango }

            Repositorio db = new Repositorio();
            db.Producto.Add(CamisaAdidas);
            db.SaveChanges();
        }
    }
}
