namespace Petshop
{
    partial class frmAnimais
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparAnimais = new System.Windows.Forms.Button();
            this.btnSalvarAnimal = new System.Windows.Forms.Button();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet1 = new Petshop.petshopDataSet1();
            this.lblRacaLiente = new System.Windows.Forms.Label();
            this.txtAlergiaAnimal = new System.Windows.Forms.TextBox();
            this.txtIdadeAnimal = new System.Windows.Forms.TextBox();
            this.cmbCorAnimal = new System.Windows.Forms.ComboBox();
            this.cmbAgressivoAnimal = new System.Windows.Forms.ComboBox();
            this.cmbSexoAnimal = new System.Windows.Forms.ComboBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.lblClienteAnimal = new System.Windows.Forms.Label();
            this.lblAlergiaAnimal = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCorAnimal = new System.Windows.Forms.Label();
            this.lblAgressivoAnimal = new System.Windows.Forms.Label();
            this.lblSexoAnimal = new System.Windows.Forms.Label();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Petshop.petshopDataSet1TableAdapters.clienteTableAdapter();
            this.animalTableAdapter = new Petshop.petshopDataSet1TableAdapters.animalTableAdapter();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaTableAdapter = new Petshop.petshopDataSet1TableAdapters.racaTableAdapter();
            this.cmbClienteAnimal = new System.Windows.Forms.ComboBox();
            this.cmbRacaAnimal = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRacaAnimal);
            this.groupBox1.Controls.Add(this.cmbClienteAnimal);
            this.groupBox1.Controls.Add(this.btnLimparAnimais);
            this.groupBox1.Controls.Add(this.btnSalvarAnimal);
            this.groupBox1.Controls.Add(this.lblRacaLiente);
            this.groupBox1.Controls.Add(this.txtAlergiaAnimal);
            this.groupBox1.Controls.Add(this.txtIdadeAnimal);
            this.groupBox1.Controls.Add(this.cmbCorAnimal);
            this.groupBox1.Controls.Add(this.cmbAgressivoAnimal);
            this.groupBox1.Controls.Add(this.cmbSexoAnimal);
            this.groupBox1.Controls.Add(this.txtNomeAnimal);
            this.groupBox1.Controls.Add(this.lblClienteAnimal);
            this.groupBox1.Controls.Add(this.lblAlergiaAnimal);
            this.groupBox1.Controls.Add(this.lblIdade);
            this.groupBox1.Controls.Add(this.lblCorAnimal);
            this.groupBox1.Controls.Add(this.lblAgressivoAnimal);
            this.groupBox1.Controls.Add(this.lblSexoAnimal);
            this.groupBox1.Controls.Add(this.lblNomeAnimal);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Animal";
            // 
            // btnLimparAnimais
            // 
            this.btnLimparAnimais.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAnimais.Location = new System.Drawing.Point(481, 388);
            this.btnLimparAnimais.Name = "btnLimparAnimais";
            this.btnLimparAnimais.Size = new System.Drawing.Size(122, 36);
            this.btnLimparAnimais.TabIndex = 17;
            this.btnLimparAnimais.Text = "Limpar";
            this.btnLimparAnimais.UseVisualStyleBackColor = true;
            this.btnLimparAnimais.Click += new System.EventHandler(this.btnLimparAnimais_Click);
            // 
            // btnSalvarAnimal
            // 
            this.btnSalvarAnimal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAnimal.Location = new System.Drawing.Point(481, 430);
            this.btnSalvarAnimal.Name = "btnSalvarAnimal";
            this.btnSalvarAnimal.Size = new System.Drawing.Size(122, 36);
            this.btnSalvarAnimal.TabIndex = 16;
            this.btnSalvarAnimal.Text = "Salvar";
            this.btnSalvarAnimal.UseVisualStyleBackColor = true;
            this.btnSalvarAnimal.Click += new System.EventHandler(this.btnSalvarAnimal_Click);
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.petshopDataSet1;
            // 
            // petshopDataSet1
            // 
            this.petshopDataSet1.DataSetName = "petshopDataSet1";
            this.petshopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRacaLiente
            // 
            this.lblRacaLiente.AutoSize = true;
            this.lblRacaLiente.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacaLiente.Location = new System.Drawing.Point(7, 419);
            this.lblRacaLiente.Name = "lblRacaLiente";
            this.lblRacaLiente.Size = new System.Drawing.Size(75, 25);
            this.lblRacaLiente.TabIndex = 7;
            this.lblRacaLiente.Text = "Raça:";
            // 
            // txtAlergiaAnimal
            // 
            this.txtAlergiaAnimal.Location = new System.Drawing.Point(137, 313);
            this.txtAlergiaAnimal.Name = "txtAlergiaAnimal";
            this.txtAlergiaAnimal.Size = new System.Drawing.Size(302, 47);
            this.txtAlergiaAnimal.TabIndex = 13;
            // 
            // txtIdadeAnimal
            // 
            this.txtIdadeAnimal.Location = new System.Drawing.Point(137, 260);
            this.txtIdadeAnimal.Name = "txtIdadeAnimal";
            this.txtIdadeAnimal.Size = new System.Drawing.Size(302, 47);
            this.txtIdadeAnimal.TabIndex = 12;
            // 
            // cmbCorAnimal
            // 
            this.cmbCorAnimal.FormattingEnabled = true;
            this.cmbCorAnimal.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Caramelo",
            "Outros"});
            this.cmbCorAnimal.Location = new System.Drawing.Point(137, 207);
            this.cmbCorAnimal.Name = "cmbCorAnimal";
            this.cmbCorAnimal.Size = new System.Drawing.Size(302, 47);
            this.cmbCorAnimal.TabIndex = 11;
            // 
            // cmbAgressivoAnimal
            // 
            this.cmbAgressivoAnimal.FormattingEnabled = true;
            this.cmbAgressivoAnimal.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cmbAgressivoAnimal.Location = new System.Drawing.Point(137, 154);
            this.cmbAgressivoAnimal.Name = "cmbAgressivoAnimal";
            this.cmbAgressivoAnimal.Size = new System.Drawing.Size(302, 47);
            this.cmbAgressivoAnimal.TabIndex = 10;
            // 
            // cmbSexoAnimal
            // 
            this.cmbSexoAnimal.FormattingEnabled = true;
            this.cmbSexoAnimal.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexoAnimal.Location = new System.Drawing.Point(137, 101);
            this.cmbSexoAnimal.Name = "cmbSexoAnimal";
            this.cmbSexoAnimal.Size = new System.Drawing.Size(302, 47);
            this.cmbSexoAnimal.TabIndex = 9;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(137, 48);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(302, 47);
            this.txtNomeAnimal.TabIndex = 8;
            // 
            // lblClienteAnimal
            // 
            this.lblClienteAnimal.AutoSize = true;
            this.lblClienteAnimal.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteAnimal.Location = new System.Drawing.Point(7, 366);
            this.lblClienteAnimal.Name = "lblClienteAnimal";
            this.lblClienteAnimal.Size = new System.Drawing.Size(95, 25);
            this.lblClienteAnimal.TabIndex = 6;
            this.lblClienteAnimal.Text = "Cliente:";
            // 
            // lblAlergiaAnimal
            // 
            this.lblAlergiaAnimal.AutoSize = true;
            this.lblAlergiaAnimal.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlergiaAnimal.Location = new System.Drawing.Point(6, 313);
            this.lblAlergiaAnimal.Name = "lblAlergiaAnimal";
            this.lblAlergiaAnimal.Size = new System.Drawing.Size(96, 25);
            this.lblAlergiaAnimal.TabIndex = 5;
            this.lblAlergiaAnimal.Text = "Alergia:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(6, 260);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(83, 25);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade:";
            // 
            // lblCorAnimal
            // 
            this.lblCorAnimal.AutoSize = true;
            this.lblCorAnimal.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorAnimal.Location = new System.Drawing.Point(6, 207);
            this.lblCorAnimal.Name = "lblCorAnimal";
            this.lblCorAnimal.Size = new System.Drawing.Size(57, 25);
            this.lblCorAnimal.TabIndex = 3;
            this.lblCorAnimal.Text = "Cor:";
            // 
            // lblAgressivoAnimal
            // 
            this.lblAgressivoAnimal.AutoSize = true;
            this.lblAgressivoAnimal.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgressivoAnimal.Location = new System.Drawing.Point(6, 154);
            this.lblAgressivoAnimal.Name = "lblAgressivoAnimal";
            this.lblAgressivoAnimal.Size = new System.Drawing.Size(120, 25);
            this.lblAgressivoAnimal.TabIndex = 2;
            this.lblAgressivoAnimal.Text = "Agressivo:";
            // 
            // lblSexoAnimal
            // 
            this.lblSexoAnimal.AutoSize = true;
            this.lblSexoAnimal.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoAnimal.Location = new System.Drawing.Point(6, 101);
            this.lblSexoAnimal.Name = "lblSexoAnimal";
            this.lblSexoAnimal.Size = new System.Drawing.Size(68, 25);
            this.lblSexoAnimal.TabIndex = 1;
            this.lblSexoAnimal.Text = "Sexo:";
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAnimal.Location = new System.Drawing.Point(6, 48);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(90, 25);
            this.lblNomeAnimal.TabIndex = 0;
            this.lblNomeAnimal.Text = "Nome: ";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.petshopDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.petshopDataSet1;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // cmbClienteAnimal
            // 
            this.cmbClienteAnimal.FormattingEnabled = true;
            this.cmbClienteAnimal.Location = new System.Drawing.Point(137, 367);
            this.cmbClienteAnimal.Name = "cmbClienteAnimal";
            this.cmbClienteAnimal.Size = new System.Drawing.Size(302, 47);
            this.cmbClienteAnimal.TabIndex = 18;
            // 
            // cmbRacaAnimal
            // 
            this.cmbRacaAnimal.FormattingEnabled = true;
            this.cmbRacaAnimal.Location = new System.Drawing.Point(137, 420);
            this.cmbRacaAnimal.Name = "cmbRacaAnimal";
            this.cmbRacaAnimal.Size = new System.Drawing.Size(302, 47);
            this.cmbRacaAnimal.TabIndex = 19;
            // 
            // frmAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 602);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnimais";
            this.Text = "frmAnimais";
            this.Load += new System.EventHandler(this.frmAnimais_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAgressivoAnimal;
        private System.Windows.Forms.Label lblSexoAnimal;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.Label lblCorAnimal;
        private System.Windows.Forms.ComboBox cmbAgressivoAnimal;
        private System.Windows.Forms.ComboBox cmbSexoAnimal;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label lblRacaLiente;
        private System.Windows.Forms.Label lblClienteAnimal;
        private System.Windows.Forms.Label lblAlergiaAnimal;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtAlergiaAnimal;
        private System.Windows.Forms.TextBox txtIdadeAnimal;
        private System.Windows.Forms.ComboBox cmbCorAnimal;
        private petshopDataSet1 petshopDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private petshopDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private petshopDataSet1TableAdapters.animalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private petshopDataSet1TableAdapters.racaTableAdapter racaTableAdapter;
        private System.Windows.Forms.Button btnLimparAnimais;
        private System.Windows.Forms.Button btnSalvarAnimal;
        private System.Windows.Forms.ComboBox cmbRacaAnimal;
        private System.Windows.Forms.ComboBox cmbClienteAnimal;
    }
}