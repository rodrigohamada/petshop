using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class Agendamentos : Form
    {
        // Credenciais do banco de dados
        private string connectionString = "Server=localhost;Database=PetShop;User ID=root;Password=12!@asSA;";
        private MySqlConnection connection;

        public Agendamentos()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadAnimalsComboBox();
            LoadClientesComboBox(); // Adicionado para carregar os clientes
            LoadClientesComboBoxPesquisa(); // Carregar os clientes para cmbClientePesquisa
            // Adiciona o manipulador de eventos ao evento SelectionChanged do DataGridView
            dataGridViewAgendamentos.SelectionChanged += dataGridViewAgendamentos_SelectionChanged;
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

        private void LoadClientesComboBox()
        {
            // Limpar itens existentes no ComboBox
            cmbCliente.Items.Clear();

            // Consultar clientes no banco de dados
            string query = "SELECT cli_codigo, cli_nome FROM cliente";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Adicionar cada cliente ao ComboBox
                    cmbCliente.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                }
            }

            // Exibir o nome do cliente no ComboBox
            cmbCliente.DisplayMember = "Value";
            // Armazenar o código do cliente como valor oculto
            cmbCliente.ValueMember = "Key";
        }

        private void LoadAnimalsComboBox()
        {
            // Limpar itens existentes no ComboBox
            cmbAnimal.Items.Clear();

            // Consultar animais no banco de dados
            string query = "SELECT ani_codigo, ani_nome FROM animal";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Adicionar cada animal ao ComboBox
                    cmbAnimal.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                }
            }

            // Exibir o nome do animal no ComboBox
            cmbAnimal.DisplayMember = "Value";
            // Armazenar o código do animal como valor oculto
            cmbAnimal.ValueMember = "Key";
        }

        private void cmbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnimal.SelectedItem != null)
            {
                // Obtém o código do animal selecionado
                int animalCodigo = ((KeyValuePair<int, string>)cmbAnimal.SelectedItem).Key;

                // Use 'animalCodigo' ao salvar o agendamento
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDatabaseConnection();
            // Associa os métodos aos eventos dos botões
            btnSalvar.Click += btnSalvar_Click;
            btnLimpar.Click += btnLimpar_Click;
            LoadClientesComboBox(); // Adicionado para carregar os clientes
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtém os valores dos controles
                int animalCodigo = ((KeyValuePair<int, string>)cmbAnimal.SelectedItem).Key;
                DateTime dataAgendamento = Convert.ToDateTime(mskData.Text);
                TimeSpan horarioAgendamento = TimeSpan.Parse(mskHorario.Text);
                string situacao = cmbSituacao.Text;

                // Insere os dados na tabela agendamento
                string query = "INSERT INTO agendamento (ag_data, ag_horario, ag_situacao, ag_animal) VALUES (@data, @horario, @situacao, @animal)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@data", dataAgendamento);
                    cmd.Parameters.AddWithValue("@horario", horarioAgendamento);
                    cmd.Parameters.AddWithValue("@situacao", situacao);
                    cmd.Parameters.AddWithValue("@animal", animalCodigo);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Agendamento salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os controles após o salvamento
                LimparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o agendamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparControles();
        }

        private void LimparControles()
        {
            // Limpa os valores nos controles
            cmbCliente.Text = string.Empty;
            mskData.Text = string.Empty;
            mskHorario.Text = string.Empty;
            cmbSituacao.SelectedIndex = -1;
            cmbAnimal.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém os valores dos controles
                int clienteCodigo = ((KeyValuePair<int, string>)cmbCliente.SelectedItem).Key; // Obtém o código do cliente
                int animalCodigo = ((KeyValuePair<int, string>)cmbAnimal.SelectedItem).Key;

                // Extrai os valores brutos das máscaras de data e hora
                string dataBruta = mskData.Text;
                string horarioBruto = mskHorario.Text;

                // Tenta converter para DateTime e TimeSpan usando os formatos desejados
                if (DateTime.TryParseExact(dataBruta, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataAgendamento)
                    && TimeSpan.TryParse(horarioBruto, out TimeSpan horarioAgendamento))
                {
                    string situacao = cmbSituacao.Text;

                    // Insere os dados na tabela agendamento
                    string query = "INSERT INTO agendamento (ag_data, ag_horario, ag_situacao, ag_animal, ag_cliente) VALUES (@data, @horario, @situacao, @animal, @cliente)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@data", dataAgendamento);
                        cmd.Parameters.AddWithValue("@horario", horarioAgendamento);
                        cmd.Parameters.AddWithValue("@situacao", situacao);
                        cmd.Parameters.AddWithValue("@animal", animalCodigo);
                        cmd.Parameters.AddWithValue("@cliente", clienteCodigo); // Adiciona o código do cliente

                        cmd.ExecuteNonQuery();
                    }

                    // Limpa os controles após o salvamento
                    LimparControles();

                    MessageBox.Show("Agendamento salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // A conversão falhou, exiba uma mensagem de erro ou trate conforme necessário
                    MessageBox.Show("Data ou horário fornecido não está em um formato válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o agendamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void LoadClientesComboBoxPesquisa()
        {
            // Limpar itens existentes no ComboBox
            cmbClientePesquisa.Items.Clear();

            // Consultar clientes distintos que realizaram pelo menos um agendamento
            string query = "SELECT DISTINCT c.cli_codigo, c.cli_nome " +
                           "FROM cliente c " +
                           "INNER JOIN animal a ON c.cli_codigo = a.ani_cliente " +
                           "INNER JOIN agendamento ag ON a.ani_codigo = ag.ag_animal";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Adicionar cada cliente ao ComboBox
                    cmbClientePesquisa.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                }
            }

            // Exibir o nome do cliente no ComboBox
            cmbClientePesquisa.DisplayMember = "Value";
            // Armazenar o código do cliente como valor oculto
            cmbClientePesquisa.ValueMember = "Key";
        }


        private void btnExibirInformacoes_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se foi selecionado um cliente para a pesquisa
                if (cmbClientePesquisa.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um cliente antes de exibir as informações.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtém o código do cliente selecionado
                int clienteCodigo = ((KeyValuePair<int, string>)cmbClientePesquisa.SelectedItem).Key;

                // Consulta as informações do agendamento do cliente selecionado
                string query = "SELECT ag.ag_codigo, ag.ag_data, ag.ag_horario, ag.ag_situacao, a.ani_nome " +
                               "FROM agendamento ag " +
                               "INNER JOIN animal a ON ag.ag_animal = a.ani_codigo " +
                               "WHERE ag.ag_cliente = @clienteCodigo";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@clienteCodigo", clienteCodigo);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Cria um DataTable para armazenar os dados
                        DataTable dataTable = new DataTable();

                        // Adiciona colunas ao DataTable
                        dataTable.Columns.Add("Código", typeof(int));
                        dataTable.Columns.Add("Data", typeof(DateTime));
                        dataTable.Columns.Add("Horário", typeof(TimeSpan));
                        dataTable.Columns.Add("Situação", typeof(string));
                        dataTable.Columns.Add("Animal", typeof(string));

                        // Preenche o DataTable com os dados do agendamento
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(
                                reader.GetInt32("ag_codigo"),
                                reader.GetDateTime("ag_data"),
                                reader.GetTimeSpan("ag_horario"),
                                reader.GetString("ag_situacao"),
                                reader.GetString("ani_nome")
                            );
                        }

                        // Atualiza o DataGridView com os dados do DataTable
                        dataGridViewAgendamentos.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter informações do agendamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewAgendamentos_SelectionChanged(object sender, EventArgs e)
        {
            // Obtém a linha selecionada, se houver alguma
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                // Obtém o código do agendamento da linha selecionada
                int codigoAgendamento = (int)dgv.SelectedRows[0].Cells["ag_codigo"].Value;

                // Consulta as informações do agendamento, incluindo detalhes do cliente
                string query = "SELECT ag.ag_codigo, ag.ag_data, ag.ag_horario, ag.ag_situacao, a.ani_nome AS animal, c.cli_nome AS cliente " +
                               "FROM agendamento ag " +
                               "INNER JOIN animal a ON ag.ag_animal = a.ani_codigo " +
                               "INNER JOIN cliente c ON ag.ag_cliente = c.cli_codigo " +
                               "WHERE ag.ag_codigo = @codigoAgendamento";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@codigoAgendamento", codigoAgendamento);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Cria um DataTable para armazenar os dados
                            DataTable dataTable = new DataTable();

                            // Adiciona colunas ao DataTable
                            dataTable.Columns.Add("Código", typeof(int));
                            dataTable.Columns.Add("Data", typeof(DateTime));
                            dataTable.Columns.Add("Horário", typeof(TimeSpan));
                            dataTable.Columns.Add("Situação", typeof(string));
                            dataTable.Columns.Add("Animal", typeof(string));
                            dataTable.Columns.Add("Cliente", typeof(string));

                            // Preenche o DataTable com os dados do agendamento
                            while (reader.Read())
                            {
                                dataTable.Rows.Add(
                                    reader.GetInt32("ag_codigo"),
                                    reader.GetDateTime("ag_data"),
                                    reader.GetTimeSpan("ag_horario"),
                                    reader.GetString("ag_situacao"),
                                    reader.GetString("animal"),
                                    reader.GetString("cliente")
                                );
                            }

                            // Atualiza o DataGridView com os dados do DataTable
                            dataGridViewAgendamentos.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter informações do agendamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





    }
}
