using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Ejercicio2
{
    public class Monedero
    {
        public decimal Saldo { get; private set; }
        public decimal Total { get; private set; }

        public int MonedaTipo { get; set; }
        public int MonedaTipoCincuentaCentimos { get; set; }
    }

}