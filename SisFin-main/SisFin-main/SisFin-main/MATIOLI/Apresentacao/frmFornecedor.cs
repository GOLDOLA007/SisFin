using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;


namespace Apresentacao
{
    public partial class frmFornecedor : Form
    {

        public frmFornecedor()
        {
            InitializeComponent();

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Fornecedor novoFornecedor = new Fornecedor
            {
                id = int.Parse(txtId.Text),
                cpf_cpnj = textCPFCNPJ.Text,
                razaoSocial = textRazaoSocial.Text,
                rua = textRua.Text,
                numero = int.Parse(textNumero.Text),
                nome = txtNome.Text,
                bairro = textBairro.Text,
                email = txtEmail.Text,
                cidade = txtCidade.Text,
                complemento = txtComplemento.Text,
                celular = txtCep.Text,
                telefone = textTelefone.Text
            };
            lstFornecedor.Items.Add($"ID: {novoFornecedor.id}, \nNome: {novoFornecedor.nome}, \nCPF/CNPJ: {novoFornecedor.cpf_cpnj}, \nRazão Social: {novoFornecedor.razaoSocial}, \nRua: {novoFornecedor.rua}, \nNúmero: {novoFornecedor.numero}, \nBairro: {novoFornecedor.bairro}, \nE-mail: {novoFornecedor.email}, \nCidade: {novoFornecedor.cidade}, \nComplemento: {novoFornecedor.complemento}, \nCEP: {novoFornecedor.cep}, \nTelefone: {novoFornecedor.telefone}, \nCelular: {novoFornecedor.celular}");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
