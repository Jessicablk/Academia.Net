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
using System.Configuration;

namespace Desafio_WF_BD
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            ClienteExiste();
        }

        public bool ClienteExiste()
        {
            if (tb_Nome.Text.Equals(tb_Nome))
            {
                MessageBox.Show("Cliente já cadastrado");
                return true;
            }

            else
            {
                Pessoa pessoas = new Pessoa(tb_Nome.Text.ToUpper(), tb_Cpf.Text,
                tb_Telefone.Text, tb_Endereco.Text.ToUpper(), tb_Cidade.Text.ToUpper(), tb_Email.Text.ToLower());
                pessoas.GravarCliente();
                dgv_Clientes.Rows.Add(new object[] { tb_Nome.Text.ToUpper(), tb_Cpf.Text, tb_Telefone.Text, 
                tb_Endereco.Text.ToUpper(), tb_Cidade.Text.ToUpper(), tb_Email.Text.ToLower() });
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            return false;
        }

        private void btn_MostarClientes_Click(object sender, EventArgs e)
        {


        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_Nome.Clear();
            tb_Cpf.Clear();
            tb_Telefone.Clear();
            tb_Endereco.Clear();
            tb_Cidade.Clear();
            tb_Email.Clear();
        }
    }
}
