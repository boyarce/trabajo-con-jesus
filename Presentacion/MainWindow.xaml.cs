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

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Compra> compras;
        private List<Producto> productosComprados;

        public MainWindow()
        {
            InitializeComponent();
            List<Producto> productos = new List<Producto>();
            productosComprados = new List<Producto>();
            compras = new List<Compra>();

            Producto naranja = new FrutaVerdura("FT",0 , "Naranja", 1000);
            productos.Add(naranja);

            Producto Manzana = new FrutaVerdura("FT", 0, "Manzana", 500);
            productos.Add(Manzana);

            Producto Coliflor = new FrutaVerdura("BL", 0, "Coliflor", 1000);
            productos.Add(Coliflor);

            Producto zanahoria = new FrutaVerdura("BL", 0, "Zanahoria", 100);
            productos.Add(zanahoria);

            Producto Porotos = new FrutaVerdura("LG", 0, "porotos", 500);
            productos.Add(Porotos);
            producto_cbx.ItemsSource = productos;
        }


        private void Agregar_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrutaVerdura p = (FrutaVerdura)producto_cbx.SelectedItem;
                FrutaVerdura fruta = new FrutaVerdura(p.Tipo, p.Cantidad, p.Nombre, p.PrecioUnitario);
                fruta.Cantidad = int.Parse(cantidad_txt.Text);

                productosComprados.Add(fruta);
                lista_dgd.ItemsSource = productosComprados;
                lista_dgd.Items.Refresh();
                //refreshTable();
            }

            catch (Exception ex)
            {
                //captura de excepción y despliegue de mensaje
                //en lbl_message_error de color rojo
                lbl_message_error.Content = ex.Message;
                lbl_message_error.Foreground = Brushes.Red;
                Console.WriteLine(ex);
            }
        }

        private void calcular_venta_btn_Click(object sender, RoutedEventArgs e)
        {
            {

                /*var TotalCompra = from p in  ;
                long sumproductos = 

                MessageBox.Show("El total de salarios a pagar es: " + sumproductos);*/

            }
        }
    }
}





