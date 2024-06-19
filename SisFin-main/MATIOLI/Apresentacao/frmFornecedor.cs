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
                cpf_cpnj = txtCPFCNPJ.Text,
                razaoSocial = txtRazaoSocial.Text,
                rua = txtRua.Text,
                numero = int.Parse(txtNumero.Text),
                nome = txtNome.Text,
                bairro = txtBairro.Text,
                email = txtEmail.Text,
                cidade = txtCidade.Text,
                complemento = txtComplemento.Text,
                celular = txtCep.Text,
                telefone = txtTelefone.Text
            };
            lstFornecedor.Items.Add($"FORNECEDOR {txtId.Text}");
            lstFornecedor.Items.Add($"ID: {novoFornecedor.id}");
            lstFornecedor.Items.Add($"Nome: {novoFornecedor.nome}");
            lstFornecedor.Items.Add($"CPF/CNPJ: {novoFornecedor.cpf_cpnj}");
            lstFornecedor.Items.Add($"Razão Social: {novoFornecedor.razaoSocial}");
            lstFornecedor.Items.Add($"Rua: {novoFornecedor.rua}");
            lstFornecedor.Items.Add($"Número: {novoFornecedor.numero}");
            lstFornecedor.Items.Add($"Bairro: {novoFornecedor.bairro}");
            lstFornecedor.Items.Add($"E-mail: {novoFornecedor.email}");
            lstFornecedor.Items.Add($"Cidade: {novoFornecedor.cidade}");
            lstFornecedor.Items.Add($"Complemento: {novoFornecedor.complemento}");
            lstFornecedor.Items.Add($"CEP: {novoFornecedor.cep}");
            lstFornecedor.Items.Add($"Telefone: {novoFornecedor.telefone}");
            lstFornecedor.Items.Add($"Celular: {novoFornecedor.celular}");
            lstFornecedor.Items.Add("===========================================");

            // Adicionar ao Banco de Dados
            string connectionString = "Data Source=143.106.241.3;Initial Catalog=Database;User ID=cl203241;Password=cl*18062007";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Fornecedor (id, cpf_cpnj, razaoSocial, rua, numero, nome, bairro, email, cidade, complemento, cep, telefone, celular) " +
                               "VALUES (@id, @cpf_cpnj, @razaoSocial, @rua, @numero, @nome, @bairro, @email, @cidade, @complemento, @cep, @telefone, @celular)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", novoFornecedor.id);
                    command.Parameters.AddWithValue("@cpf_cpnj", novoFornecedor.cpf_cpnj);
                    command.Parameters.AddWithValue("@razaoSocial", novoFornecedor.razaoSocial);
                    command.Parameters.AddWithValue("@rua", novoFornecedor.rua);
                    command.Parameters.AddWithValue("@numero", novoFornecedor.numero);
                    command.Parameters.AddWithValue("@nome", novoFornecedor.nome);
                    command.Parameters.AddWithValue("@bairro", novoFornecedor.bairro);
                    command.Parameters.AddWithValue("@email", novoFornecedor.email);
                    command.Parameters.AddWithValue("@cidade", novoFornecedor.cidade);
                    command.Parameters.AddWithValue("@complemento", novoFornecedor.complemento);
                    command.Parameters.AddWithValue("@cep", novoFornecedor.celular);
                    command.Parameters.AddWithValue("@telefone", novoFornecedor.telefone);
                    command.Parameters.AddWithValue("@celular", novoFornecedor.celular);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            radioPessoaFisica.Checked = false;
            radioPessoaJuridica.Checked = false;

            txtId.Clear();
            txtNome.Clear();
            txtCPFCNPJ.Clear();
            txtRazaoSocial.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtEmail.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();

        }

        private void textCPFCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Application.Run(new DialogExcluirFornecedorForm());
        }
    }
}
