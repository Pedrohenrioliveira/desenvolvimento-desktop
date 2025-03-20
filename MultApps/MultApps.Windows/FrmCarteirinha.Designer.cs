namespace MultApps.Windows
{
    partial class FrmCarteirinha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerador de carteirinha de acesso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ao parque";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(49, 115);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(49, 18);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.Location = new System.Drawing.Point(52, 137);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(326, 42);
            this.txtNome.TabIndex = 3;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCpf.Location = new System.Drawing.Point(52, 215);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCpf.Multiline = true;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(326, 42);
            this.txtCpf.TabIndex = 5;
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(49, 196);
            this.CPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(33, 16);
            this.CPF.TabIndex = 4;
            this.CPF.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data De Nascimento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(52, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gerar carterinha";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcbImagem);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.lblCpf);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(507, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 320);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(72, 214);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(48, 16);
            this.lblIdade.TabIndex = 10;
            this.lblIdade.Text = "IDADE";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(72, 240);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 16);
            this.lblCpf.TabIndex = 11;
            this.lblCpf.Text = "CPF   ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(70, 185);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(143, 18);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "NOME COMPLETO";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(52, 292);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(325, 20);
            this.dtpNascimento.TabIndex = 10;
            // 
            // pcbImagem
            // 
            this.pcbImagem.Location = new System.Drawing.Point(55, 32);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(170, 136);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagem.TabIndex = 12;
            this.pcbImagem.TabStop = false;
            // 
            // FrmCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCarteirinha";
            this.Text = "FrmCarteirinha";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.PictureBox pcbImagem;
    }
}