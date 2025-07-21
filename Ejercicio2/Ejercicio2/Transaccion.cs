using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ejercicio2
{
    public class Transaccion
    {
        public Producto Producto { get; set; }
        public decimal MontoPagado { get; set; } 
        public decimal Cambio { get; set; }
        public bool Exitoso { get; set; }

        public DateTime FechaHora { get; set; } 

    }
}