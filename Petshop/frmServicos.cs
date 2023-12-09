using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Petshop
{
    public partial class frmServicos : Form
    {
        // Credenciais do banco de dados
        private string connectionString = "Server=localhost;Database=PetShop;User ID=root;Password=12!@asSA;";
        private MySqlConnection connection;
        public frmServicos()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

            txtTempo.KeyPress += new KeyPressEventHandler(txtTempo_KeyPress);
            txtTempo.Validating += new CancelEventHandler(txtTempo_Validating);
            txtTempo.Validated += new EventHandler(txtTempo_Validated);

            // Chame o método para preencher o ComboBox de clientes
            PreencherClientesComboBox();
        }
        private void InitializeDatabaseConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                // Se a conexão for bem-sucedida, não exiba nenhuma mensagem.
            }
            catch (Exception ex)
            {
                // Se ocorrer um erro na conexão, exiba a mensagem de erro.
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPrecoServicos_Click(object sender, EventArgs e)
        {

        }

        private void PreencherClientesComboBox()
        {
            try
            {
                // Limpar itens existentes no ComboBox
                cmbCliente.Items.Clear();

                // Consulta SQL para obter os nomes dos clientes
                string query = "SELECT cli_nome FROM cliente";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Adicionar cada nome de cliente ao ComboBox
                        while (reader.Read())
                        {
                            string nomeCliente = reader["cli_nome"].ToString();
                            cmbCliente.Items.Add(nomeCliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter nomes de clientes: {ex.Message}", "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private decimal CalcularPreco(string descricao, int tempo)
        {
            decimal valorFixo = ObterValorFixo(descricao);

            if (tempo <= 60)
            {
                return valorFixo;
            }
            else
            {
                int minutosExcedentes = tempo - 60;
                decimal acrescimoPorMinuto = 1.0m * valorFixo / 60; // 100% do valor fixo por minuto excedente
                decimal valorAcrescido = minutosExcedentes * acrescimoPorMinuto;

                return valorFixo + valorAcrescido;
            }
        }

        private void btnLimparServicos_Click(object sender, EventArgs e)
        {
            cmbDescricao.SelectedIndex = -1;
            txtTempo.Clear();
            txtPreco.Clear();
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números para o tempo em minutos.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTempo_Validating(object sender, CancelEventArgs e)
        {
            // Verifica se o valor é um número positivo
            if (!int.TryParse(txtTempo.Text, out int tempo) || tempo <= 0)
            {
                e.Cancel = true;
                MessageBox.Show("Digite um valor válido para o tempo em minutos.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTempo_Validated(object sender, EventArgs e)
        {
            // Limpa o erro, se houver
            errorProvider.SetError(txtTempo, "");
        }
        private ErrorProvider errorProvider = new ErrorProvider();


        private void btnSalvarServicos_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(cmbDescricao.Text) || string.IsNullOrWhiteSpace(txtTempo.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.");
                return;
            }

            string descricao = cmbDescricao.Text;
            int tempo = Convert.ToInt32(txtTempo.Text);
            decimal preco = CalcularPreco(descricao, tempo);

            try
            {
                string query = "INSERT INTO servico (serv_descricao, serv_preco, serv_tempo) " +
                               "VALUES (@descricao, @preco, @tempo)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@descricao", descricao);
                    cmd.Parameters.AddWithValue("@preco", preco);
                    cmd.Parameters.AddWithValue("@tempo", tempo);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cadastro de serviço realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar serviço: {ex.Message}");
            }
        }
        private decimal ObterValorFixo(string descricao)
        {
            switch (descricao)
            {
                case "Banho":
                    return 50.00m;
                case "Tosa":
                    return 60.00m;
                case "Banho e Tosa":
                    return 110.00m;
                case "Vacinação":
                    return 20.00m;
                case "Daycare":
                    return 120.00m;
                case "Adestramento":
                    return 70.00m;
                case "SPA":
                    return 90.00m;
                default:
                    return 0.00m;
            }
        }

        private void btnCalcularServicos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTempo.Text))
            {
                MessageBox.Show("Digite um valor válido para o tempo em minutos.");
                return;
            }

            string descricao = cmbDescricao.Text;
            int tempo = Convert.ToInt32(txtTempo.Text);
            decimal preco = CalcularPreco(descricao, tempo);

            // Atualiza o TextBox de Preço (txtPreco)
            txtPreco.Text = preco.ToString("C");
        }
    }
}
