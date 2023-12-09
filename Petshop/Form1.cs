using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class frmPetShop : Form
    {
        // Ccredenciais do banco de dados
        private string connectionString = "Server=localhost;Database=PetShop;User ID=root;Password=12!@asSA;";
        private MySqlConnection connection;
        public frmPetShop()
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

        private void lblSystemPet_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "System Pet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            // Minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadClientecs cliente = new frmCadClientecs();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); // Limpa o painel
            panelCentral.Controls.Add(cliente); // Adiciona o Form no painel
            cliente.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            frmRacas racas = new frmRacas();
            racas.TopLevel = false;
            racas.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); // Limpa o painel
            panelCentral.Controls.Add(racas); // Adiciona o Form no painel
            racas.Show();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            frmAnimais animais = new frmAnimais();
            animais.TopLevel = false;
            animais.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); // Limpa o painel
            panelCentral.Controls.Add(animais); // Adiciona o Form no painel
            animais.Show();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            frmServicos servicos = new frmServicos();
            servicos.TopLevel = false;
            servicos.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); // Limpa o painel
            panelCentral.Controls.Add(servicos); // Adiciona o Form no painel
            servicos.Show();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            Agendamentos agendamentos = new Agendamentos();
            agendamentos.TopLevel = false;
            agendamentos.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); // Limpa o painel
            panelCentral.Controls.Add(agendamentos); // Adiciona o Form no painel
            agendamentos.Show();
        }
        
        // Certifique-se de fechar a conexão quando o formulário for fechado
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();

            base.OnFormClosing(e);
        }
    }
}
