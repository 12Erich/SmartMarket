using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMarket.BLL
{
    public class ProdutoBLL
    {
        public int Id_Produto { get; set; }
        public  int Cod_Produto { get; set; }
        public  int Cod_Marca { get; set; }
        public  int Cod_Categoria { get; set; }
        public  string Marca { get; set; }
        public  string Produto { get; set; }
        public  string Tipo { get; set; }
        public  string Categoria { get; set; }
        public  string Fornecedor { get; set; }
        public  DateTime Fabricacao { get; set; }
        public  DateTime Validade { get; set; }
        public  decimal Preco_Unitario { get; set; }
        public  decimal Preco_Pacote { get; set; }
        public  int Quantidade { get; set; }
        public  string Endereco { get; set; }
        public  DateTime Dt_Cadastro { get; set; }
        public  string Usr_Cadastro { get; set; }

    }
}
