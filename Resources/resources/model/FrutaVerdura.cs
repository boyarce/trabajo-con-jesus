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

        public string Tipo {

            set {
                if (!value.Equals("FR") || !value.Equals("BL") || !value.Equals("HT")
                    || !value.Equals("LG") || !value.Equals("RC"))
                {
                    throw new ArgumentException("Los tipos no corresponden");
                }
                else {
                    this.tipo = value;
                }
            }

            get { return tipo; } 
        }
    }
}
