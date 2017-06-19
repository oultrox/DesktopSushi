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
            this.lbl_username.Content = "Bienvenido, " + usuario.NOMBRE;
            ActualizarLista();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Sushi.DALC.PEDIDO pedidox = (Sushi.DALC.PEDIDO)Dg_pedidos.SelectedItem;
                Sushi.Negocio.PEDIDO pedido = new Sushi.Negocio.PEDIDO();
                if (pedidox != null)
                {
                    
                    pedido.detalle = pedidox.DETALLE;
                    pedido.direccion_id_direccion = (int)pedidox.DIRECCION_IDDIRECCION;
                    pedido.fecha = pedidox.FECHA;
                    pedido.idPedido = (int)pedidox.IDPEDIDO;
                    pedido.valor = (int)pedidox.VALOR;
                    pedido.estado = "DESPACHADO";
                    pedido.usuario_id_usuario = (int)pedidox.USUARIO_IDUSUARIO;
                    if (pedido.Update())
                    {
                        MessageBox.Show("¡Pedido despachado exitosamente!", "Aviso");
                    }
                    else
                    {
                        MessageBox.Show("¡Pedido seleccionado pero no se ha podido modificar!", "Alerta");
                    }
                    ActualizarLista();

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

        private void ActualizarLista()
        {
            pedidos = new Sushi.Negocio.PedidoCollection();

            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("pedidoViewSource"));
            //Busca los pedidos en base a su estado -> el nombre del estado debe ser exacto.
            itemCollectionViewSource.Source = pedidos.GetPedidosPorEstado("EN DESPACHO");
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
