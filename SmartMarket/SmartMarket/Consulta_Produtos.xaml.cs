using SmartMarket.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace SmartMarket
{
    /// <summary>
    /// Interação lógica para Consulta_Produtos.xam
    /// </summary>
    public partial class Consulta_Produtos : Page
    {
        public Consulta_Produtos()
        {
            InitializeComponent();
            BindCmbCategoria();

        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            Consulta();
        }

        private void BindCmbCategoria()
        {
            cmbCatProduto.ItemsSource = ProdutoDAL.GetCategoriaProduto(null).DefaultView;
        }

        private void Consulta()
        {
            try
            {
                dgDados.ItemsSource = ProdutoDAL.GetProduto(Convert.ToInt32(cmbProduto.SelectedValue.ToString())).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso", "Falha na consulta aos dados" + ex.Message, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void cmbCatProduto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbMarca.ItemsSource = ProdutoDAL.GetMarcaProduto(Convert.ToInt32(cmbCatProduto.SelectedValue.ToString())).DefaultView;
        }

        private void cmbMarca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbProduto.ItemsSource = ProdutoDAL.GetProduto(Convert.ToInt32(cmbMarca.SelectedValue.ToString())).DefaultView;
        }
    }
}
