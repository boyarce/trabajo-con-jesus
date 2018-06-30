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

        
        public string Nombre { get => nombre; set => nombre = value; }
        
        public int Cantidad
        {
            set{

                if (value >= 0)
                {
                    this.cantidad = value;
                }
                else {
                    throw new ArgumentNullException("La cantidad debe ser superior a caro '0' ");
                }
            }

            get{ return cantidad; }
           

            }

        public int PrecioUnitario
        {
            set {
                if (value >= 0)
                {
                    this.precioUnitario = value;
                }
                else {
                    throw new ArgumentException("El precio tiene que ser mayor a cero");
                }
            }

            get { return precioUnitario; }
        }
        
        public override string ToString()
        {
            return "Cantidad: "+cantidad+" "+"Nombre: "+nombre+" "+"Precio-Unitario: "+precioUnitario;
        }
    }
}
