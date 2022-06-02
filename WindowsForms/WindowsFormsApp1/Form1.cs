using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no botão Ok");
            MessageBox.Show($"Nome: {tbNome.Text}\nE-mail: {tbEmail.Text}\nEndereço: {tbEndereco.Text}\nBairro: {tbBairro.Text}\nCidade: {tbCidade.Text}\nTelefone: {tbTelefone.Text}\nSexo: {tbSexo.Text}");
            MessageBox.Show("Cadastro efetuado!");
            tbNome.Clear();
            tbEmail.Clear();
            tbEndereco.Clear();
            tbBairro.Text = "";
            tbCidade.Text = "";
            tbTelefone.Text = "";
            tbSexo.Text = "";
            lblMSG.Text = "Cadastro efetuado com sucesso! Insira um novo registro!";

        }
        private void BTCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Cancelar");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo a este lindo programa!");
        }
    }
}
