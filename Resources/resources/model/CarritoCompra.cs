using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.resources.model
{
    public class CarritoCompra
    {
        private List<Producto> productos;
        private long montoNeto;
        private long montoTotal;

        public CarritoCompra(List<Producto> productos, long montoNeto, long montoTotal)
        {
            Productos = productos;
            MontoNeto = montoNeto;
            MontoTotal = montoTotal;
        }

        public List<Producto> Productos { get => productos; set => productos = value; }
        public long MontoNeto { get => montoNeto; set => montoNeto = value; }
        public long MontoTotal { get => montoTotal; set => montoTotal = value; }
    }
}
