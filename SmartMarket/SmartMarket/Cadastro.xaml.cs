using SmartMarket.BLL;
using SmartMarket.DAL;
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

namespace SmartMarket
{
    /// <summary>
    /// Interação lógica para Cadastro.xam
    /// </summary>
    public partial class Cadastro : Page
    {
        public Cadastro()
        {
            InitializeComponent();
            BindCombos();
        }

        private void btnCadastro_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                if (!string.IsNullOrEmpty(txProduto.Text) &&
                    !string.IsNullOrEmpty(cmbMarca.SelectedValue.ToString()) &&
                    !string.IsNullOrEmpty(txQuantidade.Text) &&
                    !string.IsNullOrEmpty(txCodProduto.Text) &&
                    !string.IsNullOrEmpty(txValidade.Text) &&
                    !string.IsNullOrEmpty(txPrecoPacote.Text) &&
                    !string.IsNullOrEmpty(txPrecoUnitario.Text) &&
                    !string.IsNullOrEmpty(txEndereco.Text))
                {

                    ProdutoBLL produto = new ProdutoBLL();

                    produto.Produto = txProduto.Text;
                    produto.Cod_Produto = Convert.ToInt32(txCodProduto.Text);
                    //Produto.Id_Produto = 0;
                    produto.Categoria = "1";
                    //Produto.Cod_Categoria = null;
                    //Produto.Tipo = null;
                    produto.Marca = cmbMarca.SelectedValue.ToString();
                    //Produto.Cod_Marca = null;
                    produto.Preco_Pacote = Convert.ToDecimal(txPrecoPacote.Text);
                    produto.Preco_Unitario = Convert.ToDecimal(txPrecoUnitario.Text);
                    produto.Quantidade = Convert.ToInt32(txQuantidade.Text);
                    produto.Validade = Convert.ToDateTime(txValidade.Text);
                    produto.Endereco = txEndereco.Text;
                    //Produto.Fabricacao = null;
                    //Produto.Fornecedor = null;
                    produto.Usr_Cadastro = Environment.UserName;

                    ProdutoDAL.SaveProduto(produto);

                    MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else 
                {
                    throw new Exception("Preencha todos os campos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void BindCombos()
        {
            cmbMarca.ItemsSource = ProdutoDAL.GetMarcaProduto(null).DefaultView;
        }
    }
}
