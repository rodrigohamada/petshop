namespace Petshop
{
    partial class frmServicos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.btnCalcularServicos = new System.Windows.Forms.Button();
            this.btnLimparServicos = new System.Windows.Forms.Button();
            this.btnSalvarServicos = new System.Windows.Forms.Button();
            this.lblTempoServicos = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPrecoServicos = new System.Windows.Forms.Label();
            this.lblDescricaoServicos = new System.Windows.Forms.Label();
            this.cmbDescricao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMinutos);
            this.groupBox1.Controls.Add(this.txtTempo);
            this.groupBox1.Controls.Add(this.btnCalcularServicos);
            this.groupBox1.Controls.Add(this.btnLimparServicos);
            this.groupBox1.Controls.Add(this.btnSalvarServicos);
            this.groupBox1.Controls.Add(this.lblTempoServicos);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.lblPrecoServicos);
            this.groupBox1.Controls.Add(this.lblDescricaoServicos);
            this.groupBox1.Controls.Add(this.cmbDescricao);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(371, 223);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(82, 23);
            this.lblMinutos.TabIndex = 10;
            this.lblMinutos.Text = "Minutos";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(140, 216);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(225, 47);
            this.txtTempo.TabIndex = 9;
            // 
            // btnCalcularServicos
            // 
            this.btnCalcularServicos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularServicos.Location = new System.Drawing.Point(173, 269);
            this.btnCalcularServicos.Name = "btnCalcularServicos";
            this.btnCalcularServicos.Size = new System.Drawing.Size(167, 39);
            this.btnCalcularServicos.TabIndex = 8;
            this.btnCalcularServicos.Text = "Calcular Preço";
            this.btnCalcularServicos.UseVisualStyleBackColor = true;
            this.btnCalcularServicos.Click += new System.EventHandler(this.btnCalcularServicos_Click);
            // 
            // btnLimparServicos
            // 
            this.btnLimparServicos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparServicos.Location = new System.Drawing.Point(143, 387);
            this.btnLimparServicos.Name = "btnLimparServicos";
            this.btnLimparServicos.Size = new System.Drawing.Size(108, 29);
            this.btnLimparServicos.TabIndex = 7;
            this.btnLimparServicos.Text = "Limpar";
            this.btnLimparServicos.UseVisualStyleBackColor = true;
            this.btnLimparServicos.Click += new System.EventHandler(this.btnLimparServicos_Click);
            // 
            // btnSalvarServicos
            // 
            this.btnSalvarServicos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarServicos.Location = new System.Drawing.Point(257, 387);
            this.btnSalvarServicos.Name = "btnSalvarServicos";
            this.btnSalvarServicos.Size = new System.Drawing.Size(108, 29);
            this.btnSalvarServicos.TabIndex = 6;
            this.btnSalvarServicos.Text = "Salvar";
            this.btnSalvarServicos.UseVisualStyleBackColor = true;
            this.btnSalvarServicos.Click += new System.EventHandler(this.btnSalvarServicos_Click);
            // 
            // lblTempoServicos
            // 
            this.lblTempoServicos.AutoSize = true;
            this.lblTempoServicos.Location = new System.Drawing.Point(6, 216);
            this.lblTempoServicos.Name = "lblTempoServicos";
            this.lblTempoServicos.Size = new System.Drawing.Size(133, 39);
            this.lblTempoServicos.TabIndex = 5;
            this.lblTempoServicos.Text = "Tempo:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(143, 330);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(225, 47);
            this.txtPreco.TabIndex = 3;
            // 
            // lblPrecoServicos
            // 
            this.lblPrecoServicos.AutoSize = true;
            this.lblPrecoServicos.Location = new System.Drawing.Point(6, 330);
            this.lblPrecoServicos.Name = "lblPrecoServicos";
            this.lblPrecoServicos.Size = new System.Drawing.Size(118, 39);
            this.lblPrecoServicos.TabIndex = 2;
            this.lblPrecoServicos.Text = "Preço:";
            this.lblPrecoServicos.Click += new System.EventHandler(this.lblPrecoServicos_Click);
            // 
            // lblDescricaoServicos
            // 
            this.lblDescricaoServicos.AutoSize = true;
            this.lblDescricaoServicos.Location = new System.Drawing.Point(6, 135);
            this.lblDescricaoServicos.Name = "lblDescricaoServicos";
            this.lblDescricaoServicos.Size = new System.Drawing.Size(185, 39);
            this.lblDescricaoServicos.TabIndex = 1;
            this.lblDescricaoServicos.Text = "Descrição:";
            // 
            // cmbDescricao
            // 
            this.cmbDescricao.FormattingEnabled = true;
            this.cmbDescricao.Items.AddRange(new object[] {
            "Banho",
            "Tosa",
            "Banho e Tosa",
            "Vacinação",
            "Daycare",
            "Adestramento",
            "SPA"});
            this.cmbDescricao.Location = new System.Drawing.Point(140, 135);
            this.cmbDescricao.Name = "cmbDescricao";
            this.cmbDescricao.Size = new System.Drawing.Size(225, 47);
            this.cmbDescricao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(140, 60);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(225, 47);
            this.cmbCliente.TabIndex = 12;
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 546);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServicos";
            this.Text = "frmServicos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescricaoServicos;
        private System.Windows.Forms.ComboBox cmbDescricao;
        private System.Windows.Forms.Label lblPrecoServicos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblTempoServicos;
        private System.Windows.Forms.Button btnLimparServicos;
        private System.Windows.Forms.Button btnSalvarServicos;
        private System.Windows.Forms.Button btnCalcularServicos;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}