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
        public double DescuentoCategoria {

            set {
                if (this.categoria == 'A')
                {
                    value = 0.10;
                    descuentoCategoria = value;
                }
                else if (this.categoria == 'B')
                {
                    value = 0.20;
                    descuentoCategoria = value;
                }
                else if (this.categoria == 'C')
                {
                    value = 0.30;
                    descuentoCategoria = value;
                }
                else {
                    throw new ArgumentException("La categoria no existe");
                } 
            }
            get { return descuentoCategoria; }
        }
    }
}
