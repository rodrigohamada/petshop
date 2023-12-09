using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Petshop
{
    public partial class frmRacas : Form
    {
        // Credenciais do banco de dados
        private string connectionString = "Server=localhost;Database=PetShop;User ID=root;Password=12!@asSA;";
        private MySqlConnection connection;
        public frmRacas()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
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

        private void lblNomeRaca_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparRaca_Click(object sender, EventArgs e)
        {
            txtNomeRaca.Clear();
            txtPaisOrigemRaca.Clear();
        }

        private bool IsLettersOnly(string input)
        {
            // Verifica se a string contém apenas letras, espaços e acentos, sem caracteres especiais
            return Regex.IsMatch(input, "^[\\p{L} ]+$");
        }

        private void btnSalvarRaca_Click(object sender, EventArgs e)
        {
            string nomeRaca = txtNomeRaca.Text;
            string paisOrigem = txtPaisOrigemRaca.Text;

            // Verificar se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(nomeRaca) || string.IsNullOrWhiteSpace(paisOrigem))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se os campos aceitam somente letras
            if (!IsLettersOnly(nomeRaca) || !IsLettersOnly(paisOrigem))
            {
                MessageBox.Show("Os campos devem conter somente letras.", "Caracteres Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserir os dados no banco de dados
            try
            {
                string query = "INSERT INTO raca (raca_nome, raca_pais_origem) VALUES (@nomeRaca, @paisOrigem)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nomeRaca", nomeRaca);
                    cmd.Parameters.AddWithValue("@paisOrigem", paisOrigem);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
