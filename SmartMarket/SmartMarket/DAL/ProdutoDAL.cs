using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SmartMarket.BLL;

namespace SmartMarket.DAL
{
    public class ProdutoDAL
    {
        public static void SavePccroduto(ProdutoBLL produto)
        {
            try
            {

                //using (SqlConnection sqlcon = new SqlConnection(@ConfigurationManager.AppSettings["SqlConnection"]))
                //{
                //    using SqlCommand cmd = new SqlCommand("SP_INSERT_PRODUTO", sqlcon);
                //    sqlcon.Open();

                //    cmd.CommandType = CommandType.StoredProcedure;
                //    cmd.Parameters.Add(new SqlParameter("@Produto", produto.Produto));
                //    cmd.Parameters.Add(new SqlParameter("@Cod_Produto", produto.Cod_Produto));
                //    //Produto.Id_Produto = 0;
                //    cmd.Parameters.Add(new SqlParameter("@Categoria", produto.Categoria));
                //    //Produto.Cod_Categoria = null;
                //    //Produto.Tipo = null;
                //    cmd.Parameters.Add(new SqlParameter("@Marca", produto.Marca));
                //    //Produto.Cod_Marca = null;
                //    cmd.Parameters.Add(new SqlParameter("@Preco_Pacote", produto.Preco_Pacote));
                //    cmd.Parameters.Add(new SqlParameter("@Preco_Unitario", produto.Preco_Unitario));
                //    cmd.Parameters.Add(new SqlParameter("@Quantidade", produto.Quantidade));
                //    cmd.Parameters.Add(new SqlParameter("@Validade", produto.Validade));
                //    cmd.Parameters.Add(new SqlParameter("@Endereco", produto.Endereco));
                //    //Produto.Fabricacao = null;
                //    //Produto.Fornecedor = null;
                //    cmd.Parameters.Add(new SqlParameter("@Usr_Cadastro", produto.Usr_Cadastro));
                //    cmd.Parameters.Add(new SqlParameter("@Dt_Cadastro", produto.Dt_Cadastro));

                //    int result = cmd.ExecuteNonQuery();

                //    // Check Error
                //    if (result < 0)
                //        throw new Exception("Falha não gravação dos dados!");

                //    sqlcon.Close();
               // }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       public static void SaveProduto(ProdutoBLL produto)
        {
            try
            {
                //string connectionString = @"Data Source = ITLNB108\SQL2017; Initial Catalog = DB_SMARTMARKET; Integrated Security = True"; ;
                //SqlConnection sqlConn = new SqlConnection(connectionString);

                //sqlConn.Open();
                //SqlCommand cmd = new SqlCommand("SP_INSERT_PRODUTO", sqlConn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("@Produto", produto.Produto));
                //cmd.Parameters.Add(new SqlParameter("@Cod_Produto", produto.Cod_Produto));
                ////Produto.Id_Produto = 0;
                //cmd.Parameters.Add(new SqlParameter("@Categoria", produto.Categoria));
                ////Produto.Cod_Categoria = null;
                ////Produto.Tipo = null;
                //cmd.Parameters.Add(new SqlParameter("@Marca", produto.Marca));
                ////Produto.Cod_Marca = null;
                //cmd.Parameters.Add(new SqlParameter("@Preco_Pacote", produto.Preco_Pacote));
                //cmd.Parameters.Add(new SqlParameter("@Preco_Unitario", produto.Preco_Unitario));
                //cmd.Parameters.Add(new SqlParameter("@Quantidade", produto.Quantidade));
                //cmd.Parameters.Add(new SqlParameter("@Validade", produto.Validade));
                //cmd.Parameters.Add(new SqlParameter("@Endereco", produto.Endereco));
                ////Produto.Fabricacao = null;
                ////Produto.Fornecedor = null;
                //cmd.Parameters.Add(new SqlParameter("@Usr_Cadastro", produto.Usr_Cadastro));
                //cmd.Parameters.Add(new SqlParameter("@Dt_Cadastro", produto.Dt_Cadastro));
                //cmd.ExecuteNonQuery();
                //sqlConn.Close();

            }
            catch (Exception ex)
            {
     
            }
        }

        public static DataTable GetProduto(string Classe, string Periodo)
        {
            DataTable dt = new DataTable();

            try
            {

                //using (SqlConnection sqlcon = new SqlConnection(@ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString))
                //{
                //    using (SqlCommand cmd = new SqlCommand("SP_GET_SUSEP", sqlcon))
                //    {
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.Add(new SqlParameter("@NomeClasse", Classe));
                //        cmd.Parameters.Add(new SqlParameter("@Meses", Periodo));

                //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                //        {
                //            da.Fill(dt);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public static DataTable UpdateSusep()
        {
            DataTable dt = new DataTable();

            try
            {

                //using (SqlConnection sqlcon = new SqlConnection(@ConfigurationManager.AppSettings["SqlConnection"]))
                //{
                //    using (SqlCommand cmd = new SqlCommand("SP_INSERTSUSEP2", sqlcon))
                //    {
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.Add(new SqlParameter("@Usuario", Environment.UserName));

                //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                //        {
                //            da.Fill(dt);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public static void InsertSusep(DataTable dtSusep)
        {
            //using (SqlConnection dbConn = new SqlConnection(@ConfigurationManager.AppSettings["SqlConnection"]))
            //{
            //    dbConn.Open();
            //    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(dbConn))
            //    {
            //        bulkCopy.DestinationTableName =
            //            "dbo.tmpSusep";
            //        try
            //        {
            //            bulkCopy.WriteToServer(dtSusep, DataRowState.Added);
            //        }
            //        catch (Exception ex)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
        }
    }
}