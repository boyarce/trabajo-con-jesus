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

        public char Categoria {

            set {
                if ('A' == value || 'B' == value || 'C' == value)
                {
                    this.categoria = value;
                }
                else {
                    throw new ArgumentException("La categoria no Existe");
                }
            }

            get { return categoria; }
        }
        public double DescuentoCategoria { get => descuentoCategoria; set => descuentoCategoria = value; }


    }
}
