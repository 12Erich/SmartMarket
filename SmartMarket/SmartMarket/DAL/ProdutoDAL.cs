using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SmartMarket.BLL;

namespace SmartMarket.DAL
{
    public class ProdutoDAL
    {
        public static void SavePccroduto(ProdutoBLL produto)
        {
            try
            {

                using (SqlConnection sqlcon = new SqlConnection(Connection.Con()))
                {
                    using SqlCommand cmd = new SqlCommand("SP_INSERT_PRODUTO", sqlcon);
                    sqlcon.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Produto", produto.Produto));
                    cmd.Parameters.Add(new SqlParameter("@Cod_Produto", produto.Cod_Produto));
                    //Produto.Id_Produto = 0;
                    cmd.Parameters.Add(new SqlParameter("@Categoria", produto.Categoria));
                    //Produto.Cod_Categoria = null;
                    //Produto.Tipo = null;
                    cmd.Parameters.Add(new SqlParameter("@Marca", produto.Marca));
                    //Produto.Cod_Marca = null;
                    cmd.Parameters.Add(new SqlParameter("@Preco_Pacote", produto.Preco_Pacote));
                    cmd.Parameters.Add(new SqlParameter("@Preco_Unitario", produto.Preco_Unitario));
                    cmd.Parameters.Add(new SqlParameter("@Quantidade", produto.Quantidade));
                    cmd.Parameters.Add(new SqlParameter("@Validade", produto.Validade));
                    cmd.Parameters.Add(new SqlParameter("@Endereco", produto.Endereco));
                    //Produto.Fabricacao = null;
                    //Produto.Fornecedor = null;
                    cmd.Parameters.Add(new SqlParameter("@Usr_Cadastro", produto.Usr_Cadastro));
                    cmd.Parameters.Add(new SqlParameter("@Dt_Cadastro", produto.Dt_Cadastro));

                    int result = cmd.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        throw new Exception("Falha não gravação dos dados!");

                    sqlcon.Close();
                }
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

                using (SqlConnection sqlcon = new SqlConnection(Connection.Con()))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_INSERT_PRODUTO", sqlcon))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Produto", produto.Produto));
                        //Produto.Id_Produto = 0;
                        cmd.Parameters.Add(new SqlParameter("@Categoria", produto.Categoria));
                        //Produto.Cod_Categoria = null;
                        //Produto.Tipo = null;
                        cmd.Parameters.Add(new SqlParameter("@Marca", produto.Marca));
                        //Produto.Cod_Marca = null;
                        cmd.Parameters.Add(new SqlParameter("@Preco_Pacote", produto.Preco_Pacote));
                        cmd.Parameters.Add(new SqlParameter("@Preco_Unitario", produto.Preco_Unitario));
                        cmd.Parameters.Add(new SqlParameter("@Quantidade", produto.Quantidade));
                        cmd.Parameters.Add(new SqlParameter("@Validade", produto.Validade));
                        cmd.Parameters.Add(new SqlParameter("@Endereco", produto.Endereco));
                        //Produto.Fabricacao = null;
                        //Produto.Fornecedor = null;
                        cmd.Parameters.Add(new SqlParameter("@Usr_Cadastro", produto.Usr_Cadastro));

                        sqlcon.Open();
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
               
            }
        }

        public static DataTable GetCategoriaProduto(int? CodCategoria)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection sqlcon = new SqlConnection(Connection.Con()))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GET_CATEGORIA_PRODUTO", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@COCATEGORIA", CodCategoria));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public static DataTable GetMarcaProduto(int? CodMarca)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection sqlcon = new SqlConnection(Connection.Con()))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GET_MARCA_PRODUTO", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@CODMARCA", CodMarca));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public static DataTable GetProduto(int? CodProduto)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection sqlcon = new SqlConnection(Connection.Con()))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GET_PRODUTO", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@CODPRODUTO", CodProduto));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
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

                using (SqlConnection sqlcon = new SqlConnection(Connection.Con()))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_INSERTSUSEP2", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Usuario", Environment.UserName));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }
    }
}