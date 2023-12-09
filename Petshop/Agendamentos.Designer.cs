namespace Petshop
{
    partial class Agendamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskHorario = new System.Windows.Forms.MaskedTextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.petshopDataSet = new Petshop.petshopDataSet();
            this.petshopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet1 = new Petshop.petshopDataSet1();
            this.petshopDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExibirInformacoes = new System.Windows.Forms.Button();
            this.cmbClientePesquisa = new System.Windows.Forms.ComboBox();
            this.dataGridViewAgendamentos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mskHorario);
            this.groupBox1.Controls.Add(this.mskData);
            this.groupBox1.Controls.Add(this.cmbSituacao);
            this.groupBox1.Controls.Add(this.cmbAnimal);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(20, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Agendamento";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(260, 38);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(142, 28);
            this.cmbCliente.TabIndex = 15;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(180, 202);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 35);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(294, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 35);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Situação do Agendamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Horário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente:";
            // 
            // mskHorario
            // 
            this.mskHorario.Location = new System.Drawing.Point(260, 102);
            this.mskHorario.Mask = "00:00";
            this.mskHorario.Name = "mskHorario";
            this.mskHorario.Size = new System.Drawing.Size(142, 26);
            this.mskHorario.TabIndex = 4;
            this.mskHorario.ValidatingType = typeof(System.DateTime);
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(260, 71);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(142, 26);
            this.mskData.TabIndex = 2;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Agendado",
            "Em Andamento",
            "Finalizado"});
            this.cmbSituacao.Location = new System.Drawing.Point(260, 134);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(142, 28);
            this.cmbSituacao.TabIndex = 1;
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(260, 168);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(142, 28);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.SelectedIndexChanged += new System.EventHandler(this.cmbAnimal_SelectedIndexChanged);
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petshopDataSetBindingSource
            // 
            this.petshopDataSetBindingSource.DataSource = this.petshopDataSet;
            this.petshopDataSetBindingSource.Position = 0;
            // 
            // petshopDataSet1
            // 
            this.petshopDataSet1.DataSetName = "petshopDataSet1";
            this.petshopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petshopDataSet1BindingSource
            // 
            this.petshopDataSet1BindingSource.DataSource = this.petshopDataSet1;
            this.petshopDataSet1BindingSource.Position = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(20, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 35);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExibirInformacoes
            // 
            this.btnExibirInformacoes.Location = new System.Drawing.Point(139, 301);
            this.btnExibirInformacoes.Name = "btnExibirInformacoes";
            this.btnExibirInformacoes.Size = new System.Drawing.Size(86, 30);
            this.btnExibirInformacoes.TabIndex = 21;
            this.btnExibirInformacoes.Text = "button1";
            this.btnExibirInformacoes.UseVisualStyleBackColor = true;
            // 
            // cmbClientePesquisa
            // 
            this.cmbClientePesquisa.FormattingEnabled = true;
            this.cmbClientePesquisa.Location = new System.Drawing.Point(12, 301);
            this.cmbClientePesquisa.Name = "cmbClientePesquisa";
            this.cmbClientePesquisa.Size = new System.Drawing.Size(121, 28);
            this.cmbClientePesquisa.TabIndex = 22;
            // 
            // dataGridViewAgendamentos
            // 
            this.dataGridViewAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgendamentos.Location = new System.Drawing.Point(12, 349);
            this.dataGridViewAgendamentos.Name = "dataGridViewAgendamentos";
            this.dataGridViewAgendamentos.RowHeadersWidth = 62;
            this.dataGridViewAgendamentos.RowTemplate.Height = 28;
            this.dataGridViewAgendamentos.Size = new System.Drawing.Size(832, 241);
            this.dataGridViewAgendamentos.TabIndex = 23;
            this.dataGridViewAgendamentos.SelectionChanged += new System.EventHandler(this.dataGridViewAgendamentos_SelectionChanged);
            // 
            // Agendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(855, 602);
            this.Controls.Add(this.dataGridViewAgendamentos);
            this.Controls.Add(this.cmbClientePesquisa);
            this.Controls.Add(this.btnExibirInformacoes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agendamentos";
            this.Text = "Agendamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskHorario;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource petshopDataSetBindingSource;
        private petshopDataSet1 petshopDataSet1;
        private System.Windows.Forms.BindingSource petshopDataSet1BindingSource;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnExibirInformacoes;
        private System.Windows.Forms.ComboBox cmbClientePesquisa;
        private System.Windows.Forms.DataGridView dataGridViewAgendamentos;
    }
}