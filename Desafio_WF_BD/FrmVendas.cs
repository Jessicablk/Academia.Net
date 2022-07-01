using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Desafio_WF_BD.Conexão;

namespace Desafio_WF_BD
{
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }
        
        private void CarregarDataGrid()
        {
            Banco banco = new Banco();
            SqlConnection conexao = new SqlConnection(banco.stringConexao);
            conexao.Open();
            string sqlTexto = "SELECT idVendas, idCliente, valorTotal FROM vendas";
            SqlCommand comando = new SqlCommand(sqlTexto, conexao);
            dgv_Vendas.Rows.Clear();
            SqlDataReader leitor = comando.ExecuteReader();
            int i = 0;

            while (leitor.Read())
            {
                dgv_Vendas.Rows.Add(leitor["idVendas"].ToString());
                dgv_Vendas.Rows.Add(leitor["idCliente"].ToString());
                dgv_Vendas.Rows.Add(leitor["valorTotal"].ToString());
                i++;
            }
            conexao.Close();
        }
        private void btn_EfetuarVenda_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas(int.Parse(tb_IdVendas.Text), int.Parse(tb_IdCliente.Text), double.Parse(tb_ValorTotal.Text));
            dgv_Vendas.Rows.Add(int.Parse(tb_IdVendas.Text), int.Parse(tb_IdCliente.Text), double.Parse(tb_ValorTotal.Text));
            MessageBox.Show("Venda registrada com sucesso!");
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_IdVendas.Clear();
        }
    }
}
