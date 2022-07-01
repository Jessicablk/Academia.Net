using Desafio_WF_BD.Conexão;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_WF_BD
{
    public partial class FrmItensVendas : Form
    {
        public FrmItensVendas()
        {
            InitializeComponent();
        }

        public bool JaVendeu()
        {
            if (tb_IdProduto.Text.Equals(tb_IdProduto))
            {
                MessageBox.Show("Venda já registrada!");
                return true;
            }

            else
            {
                ItemVenda itemVenda = new ItemVenda(int.Parse(tb_IdProduto.Text),
                int.Parse(tb_IdProduto.Text), int.Parse(tb_Qntdd.Text), double.Parse(tb_TotalVendas.Text));
                itemVenda.GravarItemVenda();
                dgv_ItensVendas.Rows.Add(new object[] {int.Parse(tb_IdProduto.Text), int.Parse(tb_IdProduto.Text), int.Parse(tb_Qntdd.Text), double.Parse(tb_TotalVendas.Text)});
                MessageBox.Show("Venda cadastrada com sucesso!");
            }
            return false;
        }

        private void btn_GravarVenda_Click(object sender, EventArgs e)
        {
            JaVendeu();
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_IdProduto.Clear();
            tb_ValorUni.Clear();
            tb_Qntdd.Clear();
            tb_TotalVendas.Clear();
        }
    }
}
