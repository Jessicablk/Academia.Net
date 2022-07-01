using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Desafio_WF_BD.Conexão;

namespace Desafio_WF_BD
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        public bool ProdutoJaCadastrado()
        {
            if (tb_CodEAN.Text.Equals(tb_CodEAN))
            {
                MessageBox.Show("Produto já cadastrado!");
                return true;
            }
            else
            {
                Produtos produtos = new Produtos(int.Parse(tb_CodEAN.Text), 
                tb_NomeProduto.Text, int.Parse(tb_Estoque.Text), double.Parse(tb_ValorProduto.Text));
                dgv_Produtos.Rows.Add(new object[] {int.Parse(tb_CodEAN.Text),
                tb_NomeProduto.Text, int.Parse(tb_Estoque.Text), double.Parse(tb_ValorProduto.Text)});
                produtos.GravarProduto();
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            return false;
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            ProdutoJaCadastrado();
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_CodEAN.Clear();
            tb_NomeProduto.Clear();
            tb_Estoque.Clear();
            tb_ValorProduto.Clear();
        }
    }
}
