using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.resources.model
{
    public class FrutaVerdura : Producto
    {
        private string tipo;

        public FrutaVerdura(string tipo, int cantidad, string nombre, int precio) : base(cantidad, nombre, precio)
        {
            Tipo = tipo;
        }

        public string Tipo { get => tipo; set => tipo = value; }
    }
}
