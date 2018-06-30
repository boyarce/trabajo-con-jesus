using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.resources.model
{
    public class Compra
    {
        private string run;
        private string nombre;
        private CarritoCompra carritoCompra;

        public Compra(string run, string nombre, CarritoCompra carritoCompra)
        {
            Run = run;
            Nombre = nombre;
            CarritoCompra = carritoCompra;
        }

        public string Run { get => run; set => run = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public CarritoCompra CarritoCompra { get => carritoCompra; set => carritoCompra = value; }
    }
}
