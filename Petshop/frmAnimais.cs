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
    public partial class frmAnimais : Form
    {
        // Credenciais do banco de dados
        private string connectionString = "Server=localhost;Database=PetShop;User ID=root;Password=12!@asSA;";
        private MySqlConnection connection;

        public frmAnimais()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeComboBoxes();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComboBoxes()
        {
            CarregarClientes();
            CarregarRacas();
        }

        private void frmAnimais_Load(object sender, EventArgs e)
        {
            this.racaTableAdapter.Fill(this.petshopDataSet1.raca);
            this.animalTableAdapter.Fill(this.petshopDataSet1.animal);
            this.clienteTableAdapter.Fill(this.petshopDataSet1.cliente);
        }

        private void btnSalvarAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomeAnimal.Text) ||
                    cmbSexoAnimal.SelectedItem == null ||
                    cmbAgressivoAnimal.SelectedItem == null ||
                    cmbCorAnimal.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtIdadeAnimal.Text) ||
                    cmbClienteAnimal.SelectedItem == null ||
                    cmbRacaAnimal.SelectedItem == null)
                {
                    MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nome = txtNomeAnimal.Text;
                string sexo = cmbSexoAnimal.SelectedItem.ToString();
                string agressivo = cmbAgressivoAnimal.SelectedItem.ToString();
                string cor = cmbCorAnimal.SelectedItem.ToString();

                if (!int.TryParse(txtIdadeAnimal.Text, out int idade))
                {
                    MessageBox.Show("A idade deve ser um valor numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string alergia = txtAlergiaAnimal.Text;
                ComboboxItem clienteSelecionado = (ComboboxItem)cmbClienteAnimal.SelectedItem;
                int clienteId = clienteSelecionado.Value;

                ComboboxItem racaSelecionada = (ComboboxItem)cmbRacaAnimal.SelectedItem;
                int racaId = racaSelecionada.Value;

                string query = "INSERT INTO animal (ani_nome, ani_sexo, ani_agressivo, ani_cor, ani_idade, ani_alergia, ani_cliente, ani_raca) " +
                               "VALUES (@nome, @sexo, @agressivo, @cor, @idade, @alergia, @cliente, @raca)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@agressivo", agressivo);
                    cmd.Parameters.AddWithValue("@cor", cor);
                    cmd.Parameters.AddWithValue("@idade", idade);
                    cmd.Parameters.AddWithValue("@alergia", alergia);
                    cmd.Parameters.AddWithValue("@cliente", clienteId);
                    cmd.Parameters.AddWithValue("@raca", racaId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cadastro de animal realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar animal: {ex.Message}");
            }
        }

        private void btnLimparAnimais_Click(object sender, EventArgs e)
        {
            LimparCamposAnimal();
        }

        private void CarregarClientes()
        {
            try
            {
                List<ComboboxItem> clientes = ObterClientesDoBancoDeDados();
                cmbClienteAnimal.Items.Clear();
                foreach (var cliente in clientes)
                {
                    cmbClienteAnimal.Items.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}");
            }
        }

        private void CarregarRacas()
        {
            try
            {
                List<ComboboxItem> racas = ObterRacasDoBancoDeDados();
                cmbRacaAnimal.Items.Clear();
                foreach (var raca in racas)
                {
                    cmbRacaAnimal.Items.Add(raca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar raças: {ex.Message}");
            }
        }

        private List<ComboboxItem> ObterClientesDoBancoDeDados()
        {
            List<ComboboxItem> clientes = new List<ComboboxItem>();
            try
            {
                string query = "SELECT cli_codigo, cli_nome FROM cliente";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int codigo = reader.GetInt32("cli_codigo");
                            string nome = reader.GetString("cli_nome");
                            clientes.Add(new ComboboxItem(codigo, nome));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter clientes do banco de dados: {ex.Message}");
            }
            return clientes;
        }

        private List<ComboboxItem> ObterRacasDoBancoDeDados()
        {
            List<ComboboxItem> racas = new List<ComboboxItem>();
            try
            {
                string query = "SELECT raca_codigo, raca_nome FROM raca";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int codigo = reader.GetInt32("raca_codigo");
                            string nome = reader.GetString("raca_nome");
                            racas.Add(new ComboboxItem(codigo, nome));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter raças do banco de dados: {ex.Message}");
            }
            return racas;
        }

        private void LimparCamposAnimal()
        {
            txtNomeAnimal.Clear();
            cmbSexoAnimal.SelectedIndex = -1;
            cmbAgressivoAnimal.SelectedIndex = -1;
            cmbCorAnimal.SelectedIndex = -1;
            txtIdadeAnimal.Clear();
            txtAlergiaAnimal.Clear();
            cmbClienteAnimal.SelectedIndex = -1;
            cmbRacaAnimal.SelectedIndex = -1;
        }

        public class ComboboxItem
        {
            public int Value { get; set; }
            public string Text { get; set; }

            public ComboboxItem(int value, string text)
            {
                Value = value;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
