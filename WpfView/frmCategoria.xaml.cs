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
    /// Lógica interna para frmCategoria.xaml
    /// </summary>
    public partial class frmCategoria : Window
    {
        private CategoriasController categoriaController = new CategoriasController();
        private Categoria categoria = new Categoria();

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            categoria.Ativo = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            categoria.Ativo = true;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            
            categoria.Nome = TextBoxName.Text;
            categoriaController.Adicionar(categoria);
            if (MessageBox.Show("Deseja cadastrar mais usuários ?", "Confirmação", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                Close();
            }
            else
            {
                TextBoxName.Clear();
            }
        }
    }
}
