using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.resources.model
{
    public class Carne : Producto
    {
        private char categoria;
        private double descuentoCategoria;

        public Carne(char categoria, double descuentoCategoria, int cantidad, string nombre, int precio) : base(cantidad, nombre, precio)
        {
            Categoria = categoria;
            DescuentoCategoria = descuentoCategoria;
        }

        public char Categoria { get => categoria; set => categoria = value; }
        public double DescuentoCategoria { get => descuentoCategoria; set => descuentoCategoria = value; }
    }
}
