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
using System.Windows.Shapes;
using Sushi.Negocio;
using CryptoLib;

namespace SushiWPF
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Ingreso();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ingreso();
        }


        private void Ingreso()
        {
            UsuarioCollection listaUsuarios = new UsuarioCollection();

            try
            {
                txtPwd.Password = Encryptor.MD5Hash(this.txtPwd.Password);
                foreach (Sushi.DALC.USUARIO usuario in listaUsuarios.GetUsuarios())
                {
                    if (usuario.EMAIL.Trim() == txtUserName.Text && usuario.PASS.Trim() == txtPwd.Password)
                    {
                        MainWindow despachador = new MainWindow(usuario);
                        despachador.Show();
                        this.Close();
                    }
                }
                this.lblMessage.Content = "Error - Usuario no encontrado.";
                this.txtPwd.Password = "";
            }
            catch (Exception)
            {

            }
        }
    }
}
