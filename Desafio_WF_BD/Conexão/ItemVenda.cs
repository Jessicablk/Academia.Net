using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Desafio_WF_BD.Conexão
{
    internal class ItemVenda
    {
        public int IdProduto;
        public double ValorUnidade;
        public int Quantidade;
        public double ValorTotal;

        public ItemVenda(int idProduto, double valorUnidade, int quantidade, double valorTotal)
        {
            IdProduto = idProduto;
            ValorUnidade = valorUnidade;
            Quantidade = quantidade;
            ValorTotal = valorUnidade * quantidade;
        }

        public ItemVenda()
        {

        }

        public bool GravarItemVenda()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into itemVenda values (@idProduto, @valorUnidade, @quantidade, @valorTotal);";
            command.Parameters.Add("@idProduto", SqlDbType.Int);
            command.Parameters.Add("@valorUnidade", SqlDbType.Real);
            command.Parameters.Add("@quantidade", SqlDbType.Int);
            command.Parameters.Add("@valorTotal", SqlDbType.Real);
            command.Parameters[0].Value = IdProduto;
            command.Parameters[1].Value = ValorUnidade;
            command.Parameters[2].Value = Quantidade;
            command.Parameters[3].Value = ValorTotal;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}

