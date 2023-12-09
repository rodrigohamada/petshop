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
    public partial class frmCadClientecs : Form
    {
        // Credenciais do banco de dados
        private string connectionString = "Server=localhost;Database=PetShop;User ID=root;Password=12!@asSA;";
        private MySqlConnection connection;
        public frmCadClientecs()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar todas as caixas de texto
            txtNomeCliente.Clear();
            mskCelular.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            txtEndereco.Clear();
        }

        private bool ClienteJaCadastrado(string cpf, string celular, string email)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM cliente WHERE cli_cpf = @cpf OR cli_celular = @celular OR cli_email = @email";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@celular", celular);
                    cmd.Parameters.AddWithValue("@email", email);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        if (cpfJaCadastrado(cpf))
                        {
                            MessageBox.Show("CPF já cadastrado. Por favor, verifique.");
                            return true;
                        }
                        else if (celularJaCadastrado(celular))
                        {
                            MessageBox.Show("Celular já cadastrado. Por favor, verifique.");
                            return true;
                        }
                        else if (emailJaCadastrado(email))
                        {
                            MessageBox.Show("E-mail já cadastrado. Por favor, verifique.");
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar cadastro do cliente: {ex.Message}");
            }

            return false;
        }

        private bool cpfJaCadastrado(string cpf)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM cliente WHERE cli_cpf = @cpf";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar cadastro do CPF: {ex.Message}");
            }

            return false;
        }

        private bool celularJaCadastrado(string celular)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM cliente WHERE cli_celular = @celular";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@celular", celular);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar cadastro do celular: {ex.Message}");
            }

            return false;
        }

        private bool emailJaCadastrado(string email)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM cliente WHERE cli_email = @email";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar cadastro do e-mail: {ex.Message}");
            }

            return false;
        }

        private bool IsEmailValid(string email)
        {
            // Esta função verifica se o e-mail contém pelo menos um '@' e um domínio válido, sem caracteres especiais.
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

private string RemoverEspacos(string texto)
{
    // Remover espaços em branco no início e no final da string
    return texto.Trim();
}

        private bool ValidarCPF(string cpf)
        {
            // Remove espaços em branco e verifica se o CPF possui 11 dígitos
            cpf = RemoverEspacos(cpf);
            if (cpf.Length != 11)
            {
                MessageBox.Show("CPF inválido. Certifique-se de inserir 11 dígitos.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarCelular(string celular)
        {
            // Remove espaços em branco e verifica se o celular possui um formato válido
            celular = RemoverEspacos(celular);

            if (celular.Length < 10 || celular.Length > 11)
            {
                MessageBox.Show("Número de celular inválido. Certifique-se de inserir entre 10 e 11 dígitos.", "Celular Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarNome(string nome)
        {
            // Verificar se o nome contém apenas letras, espaços e acentos comuns
            if (!Regex.IsMatch(nome, "^[a-zA-ZáéíóúâêîôûãõàèìòùäëïöüçÁÉÍÓÚÂÊÎÔÛÃÕÀÈÌÒÙÄËÏÖÜÇ ]+$"))
            {
                MessageBox.Show("O nome não pode conter caracteres especiais, números ou outros símbolos.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Coletar informações do formulário
            string nome = txtNomeCliente.Text;
            string celular = RemoverEspacos(mskCelular.Text);
            string email = txtEmail.Text.Trim();
            string cpf = RemoverEspacos(mskCPF.Text);
            string endereco = txtEndereco.Text;

            // Verificar se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(celular) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar nome
            if (!ValidarNome(nome))
            {
                return;
            }

            // Validar CPF
            if (!ValidarDocumento(cpf, "CPF"))
            {
                return;
            }

            // Validar Celular
            if (!ValidarDocumento(celular, "Celular"))
            {
                return;
            }

            // Verificar se o cliente já está cadastrado
            if (ClienteJaCadastrado(cpf, celular, email))
            {
                return;
            }

            // Verificar se o e-mail é válido
            if (!IsEmailValid(email))
            {
                MessageBox.Show("O e-mail inserido não é válido.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserir os dados no banco de dados
            try
            {
                string query = "INSERT INTO cliente (cli_nome, cli_celular, cli_email, cli_cpf, cli_endereco) " +
                               "VALUES (@nome, @celular, @email, @cpf, @endereco)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@celular", celular);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@endereco", endereco);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}");
            }
        }

        private bool ValidarDocumento(string documento, string tipoDocumento)
        {
            // Remover espaços em branco e caracteres não numéricos
            documento = new string(documento.Where(char.IsDigit).ToArray());

            if (documento.Length != 11)
            {
                MessageBox.Show($"{tipoDocumento} inválido. Certifique-se de inserir 11 dígitos.", $"{tipoDocumento} Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
