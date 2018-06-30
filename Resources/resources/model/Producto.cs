using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.resources.model
{
    public class Producto
    {
        private int cantidad;
        private string nombre;
        private int precioUnitario;

        public Producto(int cantidad, string nombre, int precio)
        {
            Cantidad = cantidad;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }

        public override string ToString()
        {
            return "Cantidad: "+cantidad+" "+"Nombre: "+nombre+" "+"Precio-Unitario: "+precioUnitario;
        }
    }
}
