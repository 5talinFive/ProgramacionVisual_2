using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Entidades
{
    public class Configuracion
    {
        //Propiedades 
        public int ConfiguracionId { get; set; }
        public string NombreBodega { get; set; }
        public int valorminimo { get; set; }

        //Stock minimo 
        public float PesoCantidad { get; set; }
        public float PesoStock { get; set; }

        //Total 
        public float Stockminimo { get; set; }
    }
}
