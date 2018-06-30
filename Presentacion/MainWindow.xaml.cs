using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Resources;
using Resources.resources.model;

namespace Presentacion
{
    private List<Compra> compras;

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Producto> productos = new List<Producto>();
            //productos.Add =   

            producto_cbx.ItemsSource = productos;
        }

        private void Agregar_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CarritoCompra Carritocompra = new CarritoCompra();
                CarritoModel carrito = new CarritoModel(run_txt.Text, nombre_txt.Text, producto_cbx.ItemsSource,
                                                long.Parse(cantidad_txt.Text));
                carritoCompra.createCarrito(carrito);

                carrito.Add(carrito);

                refreshTable();
            }
            }
            catch (CarritoException ex)
            {
                //captura de excepción y despliegue de mensaje
                //en lbl_message_error de color rojo
                lbl_message_error.Content = ex.Message;
                lbl_message_error.Foreground = Brushes.Red;
                Console.WriteLine(ex);
            }
}
private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
        }
    }
    }
}
