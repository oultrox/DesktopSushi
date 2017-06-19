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

namespace SushiWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sushi.Negocio.PedidoCollection pedidos;
        public MainWindow(Sushi.DALC.USUARIO usuario)
        {
            InitializeComponent();
            pedidos = new Sushi.Negocio.PedidoCollection();

            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("pedidoViewSource"));
            //Busca los pedidos en base a su estado -> el nombre del estado debe ser exacto.
            itemCollectionViewSource.Source = pedidos.GetPedidosPorEstado("PAGADO");
            this.lbl_username.Content = "Bienvenido, "+ usuario.NOMBRE;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Sushi.Negocio.PEDIDO pedidox = (Sushi.Negocio.PEDIDO)Dg_pedidos.SelectedItem;

                if (pedidox != null)
                {
                    pedidox.estado = "DESPACHADO";
                    pedidox.Update();
                    MessageBox.Show("¡Pedido despachado exitosamente!", "Aviso");
                    //Sushi.Negocio.PEDIDO pedido = new Sushi.Negocio.PEDIDO();

                }
                else
                {
                    MessageBox.Show("¡Debe seleccionar un Pedido de la lista!", "Error");
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void Dg_pedidos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
