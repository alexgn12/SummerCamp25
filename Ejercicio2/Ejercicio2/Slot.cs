using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    public class Slot
    {
        public string Identificador { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; } // Cantidad actual del producto en el slot

        public int Capacidad { get; set; } // Capacidad máxima del slot 
        public DateTime UltimaReposicion { get; set; } // Fecha y hora de la última reposición
        public int StockMinimo { get; set; } // Stock mínimo para considerar que el slot está vacío

        // Metodo para reponer el slot
        public void Reponer(int cantidad)
        {
            if (Cantidad + cantidad <= Capacidad)
            {
                Cantidad += cantidad;
                UltimaReposicion = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("La cantidad a reponer excede la capacidad del slot.");
            }
        }
        // Establecer el producto en el slot
        public void EstablecerProducto(Producto producto)
        {
            Producto = producto;
            Cantidad = 0; // Inicialmente no hay productos en el slot
            UltimaReposicion = DateTime.Now; // Fecha de reposición inicial
        }

        // Verificar si el slot necesita reposición
        public bool NecesitaReposicion()
        {
            return Cantidad < StockMinimo;
        }

        public bool RetirarProducto(int cantidad)
        {
            if (Cantidad >= cantidad)
            {
                Cantidad -= cantidad;
                return true; // Retiro exitoso
            }
            else
            {
                return false; // No hay suficiente producto para retirar
            }
        }
        // Si existe el producto en el slot, retornar true
        public bool ContieneProducto(string nombreProducto)
        {
            return Producto != null && Producto.Nombre.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase);
        }
    }
}