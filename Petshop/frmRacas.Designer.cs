namespace Petshop
{
    partial class frmRacas
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
            this.lblNomeRaca = new System.Windows.Forms.Label();
            this.lblPaisdeOrigemRaca = new System.Windows.Forms.Label();
            this.txtNomeRaca = new System.Windows.Forms.TextBox();
            this.txtPaisOrigemRaca = new System.Windows.Forms.TextBox();
            this.btnSalvarRaca = new System.Windows.Forms.Button();
            this.btnLimparRaca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimparRaca);
            this.groupBox1.Controls.Add(this.btnSalvarRaca);
            this.groupBox1.Controls.Add(this.txtPaisOrigemRaca);
            this.groupBox1.Controls.Add(this.txtNomeRaca);
            this.groupBox1.Controls.Add(this.lblPaisdeOrigemRaca);
            this.groupBox1.Controls.Add(this.lblNomeRaca);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 578);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Raças";
            // 
            // lblNomeRaca
            // 
            this.lblNomeRaca.AutoSize = true;
            this.lblNomeRaca.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRaca.Location = new System.Drawing.Point(19, 107);
            this.lblNomeRaca.Name = "lblNomeRaca";
            this.lblNomeRaca.Size = new System.Drawing.Size(268, 39);
            this.lblNomeRaca.TabIndex = 0;
            this.lblNomeRaca.Text = "Nome da Raça:";
            this.lblNomeRaca.Click += new System.EventHandler(this.lblNomeRaca_Click);
            // 
            // lblPaisdeOrigemRaca
            // 
            this.lblPaisdeOrigemRaca.AutoSize = true;
            this.lblPaisdeOrigemRaca.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaisdeOrigemRaca.Location = new System.Drawing.Point(19, 178);
            this.lblPaisdeOrigemRaca.Name = "lblPaisdeOrigemRaca";
            this.lblPaisdeOrigemRaca.Size = new System.Drawing.Size(410, 39);
            this.lblPaisdeOrigemRaca.TabIndex = 1;
            this.lblPaisdeOrigemRaca.Text = "País de Origem da Raça:";
            // 
            // txtNomeRaca
            // 
            this.txtNomeRaca.Location = new System.Drawing.Point(336, 107);
            this.txtNomeRaca.Name = "txtNomeRaca";
            this.txtNomeRaca.Size = new System.Drawing.Size(279, 47);
            this.txtNomeRaca.TabIndex = 2;
            // 
            // txtPaisOrigemRaca
            // 
            this.txtPaisOrigemRaca.Location = new System.Drawing.Point(336, 178);
            this.txtPaisOrigemRaca.Name = "txtPaisOrigemRaca";
            this.txtPaisOrigemRaca.Size = new System.Drawing.Size(279, 47);
            this.txtPaisOrigemRaca.TabIndex = 3;
            // 
            // btnSalvarRaca
            // 
            this.btnSalvarRaca.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarRaca.Location = new System.Drawing.Point(495, 248);
            this.btnSalvarRaca.Name = "btnSalvarRaca";
            this.btnSalvarRaca.Size = new System.Drawing.Size(120, 33);
            this.btnSalvarRaca.TabIndex = 4;
            this.btnSalvarRaca.Text = "Salvar";
            this.btnSalvarRaca.UseVisualStyleBackColor = true;
            this.btnSalvarRaca.Click += new System.EventHandler(this.btnSalvarRaca_Click);
            // 
            // btnLimparRaca
            // 
            this.btnLimparRaca.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparRaca.Location = new System.Drawing.Point(369, 248);
            this.btnLimparRaca.Name = "btnLimparRaca";
            this.btnLimparRaca.Size = new System.Drawing.Size(120, 33);
            this.btnLimparRaca.TabIndex = 5;
            this.btnLimparRaca.Text = "Limpar";
            this.btnLimparRaca.UseVisualStyleBackColor = true;
            this.btnLimparRaca.Click += new System.EventHandler(this.btnLimparRaca_Click);
            // 
            // frmRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 602);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRacas";
            this.Text = "frmRacas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPaisdeOrigemRaca;
        private System.Windows.Forms.Label lblNomeRaca;
        private System.Windows.Forms.Button btnLimparRaca;
        private System.Windows.Forms.Button btnSalvarRaca;
        private System.Windows.Forms.TextBox txtPaisOrigemRaca;
        private System.Windows.Forms.TextBox txtNomeRaca;
    }
}