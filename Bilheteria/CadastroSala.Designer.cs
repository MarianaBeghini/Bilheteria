namespace Bilheteria
{
    partial class Cadastro_Sala
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNomeSala = new System.Windows.Forms.Label();
            this.txbLotacao = new System.Windows.Forms.TextBox();
            this.Lotação = new System.Windows.Forms.Label();
            this.txbSala = new System.Windows.Forms.TextBox();
            this.Climatizado = new System.Windows.Forms.Label();
            this.Animação = new System.Windows.Forms.Label();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.txbAnimacao = new System.Windows.Forms.TextBox();
            this.txbClimatizado = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bntVendasIngressos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeSala
            // 
            this.lblNomeSala.AutoSize = true;
            this.lblNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSala.Location = new System.Drawing.Point(43, 113);
            this.lblNomeSala.Name = "lblNomeSala";
            this.lblNomeSala.Size = new System.Drawing.Size(45, 20);
            this.lblNomeSala.TabIndex = 1;
            this.lblNomeSala.Text = "Sala";
            // 
            // txbLotacao
            // 
            this.txbLotacao.Location = new System.Drawing.Point(171, 150);
            this.txbLotacao.Name = "txbLotacao";
            this.txbLotacao.Size = new System.Drawing.Size(171, 20);
            this.txbLotacao.TabIndex = 2;
            // 
            // Lotação
            // 
            this.Lotação.AutoSize = true;
            this.Lotação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lotação.Location = new System.Drawing.Point(42, 148);
            this.Lotação.Name = "Lotação";
            this.Lotação.Size = new System.Drawing.Size(74, 20);
            this.Lotação.TabIndex = 3;
            this.Lotação.Text = "Lotação";
            // 
            // txbSala
            // 
            this.txbSala.Location = new System.Drawing.Point(171, 113);
            this.txbSala.Name = "txbSala";
            this.txbSala.Size = new System.Drawing.Size(171, 20);
            this.txbSala.TabIndex = 4;
            // 
            // Climatizado
            // 
            this.Climatizado.AutoSize = true;
            this.Climatizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Climatizado.Location = new System.Drawing.Point(43, 218);
            this.Climatizado.Name = "Climatizado";
            this.Climatizado.Size = new System.Drawing.Size(102, 20);
            this.Climatizado.TabIndex = 6;
            this.Climatizado.Text = "Climatizado";
            // 
            // Animação
            // 
            this.Animação.AutoSize = true;
            this.Animação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animação.Location = new System.Drawing.Point(42, 183);
            this.Animação.Name = "Animação";
            this.Animação.Size = new System.Drawing.Size(88, 20);
            this.Animação.TabIndex = 7;
            this.Animação.Text = "Animação";
            // 
            // bntLimpar
            // 
            this.bntLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLimpar.Location = new System.Drawing.Point(322, 282);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(84, 23);
            this.bntLimpar.TabIndex = 9;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = false;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalvar.Location = new System.Drawing.Point(40, 282);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(91, 23);
            this.bntSalvar.TabIndex = 10;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = false;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // txbAnimacao
            // 
            this.txbAnimacao.Location = new System.Drawing.Point(171, 183);
            this.txbAnimacao.Name = "txbAnimacao";
            this.txbAnimacao.Size = new System.Drawing.Size(171, 20);
            this.txbAnimacao.TabIndex = 11;
            // 
            // txbClimatizado
            // 
            this.txbClimatizado.Location = new System.Drawing.Point(171, 218);
            this.txbClimatizado.Name = "txbClimatizado";
            this.txbClimatizado.Size = new System.Drawing.Size(171, 20);
            this.txbClimatizado.TabIndex = 12;
            // 
            // bntVendasIngressos
            // 
            this.bntVendasIngressos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntVendasIngressos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntVendasIngressos.Location = new System.Drawing.Point(196, 352);
            this.bntVendasIngressos.Name = "bntVendasIngressos";
            this.bntVendasIngressos.Size = new System.Drawing.Size(210, 23);
            this.bntVendasIngressos.TabIndex = 13;
            this.bntVendasIngressos.Text = "Vendas de Ingressos";
            this.bntVendasIngressos.UseVisualStyleBackColor = false;
            this.bntVendasIngressos.Click += new System.EventHandler(this.bntVendasIngressos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de Sala";
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(41, 325);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(90, 23);
            this.voltar.TabIndex = 15;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // Cadastro_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 387);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntVendasIngressos);
            this.Controls.Add(this.txbClimatizado);
            this.Controls.Add(this.txbAnimacao);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.Animação);
            this.Controls.Add(this.Climatizado);
            this.Controls.Add(this.txbSala);
            this.Controls.Add(this.Lotação);
            this.Controls.Add(this.txbLotacao);
            this.Controls.Add(this.lblNomeSala);
            this.Name = "Cadastro_Sala";
            this.Text = "Cadastro_Sala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNomeSala;
        private System.Windows.Forms.TextBox txbLotacao;
        private System.Windows.Forms.Label Lotação;
        private System.Windows.Forms.TextBox txbSala;
        private System.Windows.Forms.Label Climatizado;
        private System.Windows.Forms.Label Animação;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.TextBox txbAnimacao;
        private System.Windows.Forms.TextBox txbClimatizado;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button bntVendasIngressos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voltar;
    }
}