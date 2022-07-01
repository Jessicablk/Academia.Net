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
    internal class Vendas
    {
        public int IdVenda;
        public int IdCliente;
        public double ValorTotal;

        public Vendas(int idVenda, int idCliente, double valorTotal)
        {
            IdVenda = idVenda;
            IdCliente = idCliente;
            ValorTotal = valorTotal;
        }
        public bool GravarVendas()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into vendas values (@idVendas, @idCliente, @valorTotal);";
            command.Parameters.Add("@idVendas", SqlDbType.Int);
            command.Parameters.Add("@idCliente", SqlDbType.Int);
            command.Parameters.Add("@valorTotal", SqlDbType.Real);
            command.Parameters[0].Value = IdVenda;
            command.Parameters[1].Value = IdCliente;
            command.Parameters[2].Value = ValorTotal;

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

