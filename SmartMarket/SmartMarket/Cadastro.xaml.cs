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
           // InitializeComponent();
        }

        private void btnCadaistro_Click(object sender, RoutedEventArgs e)
        {
            ProdutoBLL produto = new ProdutoBLL();
            try
            {

                //produto.Produto = txProduto.Text;
                //produto.Cod_Produto = Convert.ToInt32(txCodProduto.Text);
                ////Produto.Id_Produto = 0;
                //produto.Categoria = "1";
                ////Produto.Cod_Categoria = null;
                ////Produto.Tipo = null;
                //produto.Marca = txMarca.Text;
                ////Produto.Cod_Marca = null;
                //produto.Preco_Pacote = Convert.ToDecimal(txPrecoPacote.Text);
                //produto.Preco_Unitario = Convert.ToDecimal(txPrecoUnitario.Text);
                //produto.Quantidade = Convert.ToInt32(txQuantidade.Text);
                //produto.Validade = Convert.ToDateTime(txValidade.Text);
                //produto.Endereco = txEndereco.Text;
                ////Produto.Fabricacao = null;
                ////Produto.Fornecedor = null;
                //produto.Usr_Cadastro = Environment.UserName;
                //produto.Dt_Cadastro = DateTime.Now;

                ProdutoDAL.SaveProduto(produto);
            }
            catch (Exception ex)
            {
            }

        }
    }
}
