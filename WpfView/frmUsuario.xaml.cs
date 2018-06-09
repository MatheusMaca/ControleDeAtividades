using Controllers;
using Modelos;
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

namespace WpfView
{
    /// <summary>
    /// Lógica interna para frmUsuario.xaml
    /// </summary>
    public partial class frmUsuario : Window
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var usuario = new Usuario();
            var usuarioController = new UsuariosController();
            usuario.Nome = TextBoxName.Text;
            usuario.Ativo = true;
            usuarioController.Adicionar(usuario);
            if (MessageBox.Show("Deseja cadastrar mais usuários ?", "Confirmação", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                this.Close();
            }
            else
            {
                TextBoxName.Clear();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
