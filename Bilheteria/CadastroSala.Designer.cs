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
            this.SuspendLayout();
            // 
            // lblNomeSala
            // 
            this.lblNomeSala.AutoSize = true;
            this.lblNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSala.Location = new System.Drawing.Point(43, 23);
            this.lblNomeSala.Name = "lblNomeSala";
            this.lblNomeSala.Size = new System.Drawing.Size(45, 20);
            this.lblNomeSala.TabIndex = 1;
            this.lblNomeSala.Text = "Sala";
            // 
            // txbLotacao
            // 
            this.txbLotacao.Location = new System.Drawing.Point(171, 67);
            this.txbLotacao.Name = "txbLotacao";
            this.txbLotacao.Size = new System.Drawing.Size(171, 20);
            this.txbLotacao.TabIndex = 2;
            // 
            // Lotação
            // 
            this.Lotação.AutoSize = true;
            this.Lotação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lotação.Location = new System.Drawing.Point(43, 65);
            this.Lotação.Name = "Lotação";
            this.Lotação.Size = new System.Drawing.Size(74, 20);
            this.Lotação.TabIndex = 3;
            this.Lotação.Text = "Lotação";
            // 
            // txbSala
            // 
            this.txbSala.Location = new System.Drawing.Point(171, 25);
            this.txbSala.Name = "txbSala";
            this.txbSala.Size = new System.Drawing.Size(171, 20);
            this.txbSala.TabIndex = 4;
            // 
            // Climatizado
            // 
            this.Climatizado.AutoSize = true;
            this.Climatizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Climatizado.Location = new System.Drawing.Point(43, 145);
            this.Climatizado.Name = "Climatizado";
            this.Climatizado.Size = new System.Drawing.Size(102, 20);
            this.Climatizado.TabIndex = 6;
            this.Climatizado.Text = "Climatizado";
            // 
            // Animação
            // 
            this.Animação.AutoSize = true;
            this.Animação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animação.Location = new System.Drawing.Point(43, 104);
            this.Animação.Name = "Animação";
            this.Animação.Size = new System.Drawing.Size(88, 20);
            this.Animação.TabIndex = 7;
            this.Animação.Text = "Animação";
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(267, 213);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 9;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(47, 213);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(85, 22);
            this.bntSalvar.TabIndex = 10;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // txbAnimacao
            // 
            this.txbAnimacao.Location = new System.Drawing.Point(171, 106);
            this.txbAnimacao.Name = "txbAnimacao";
            this.txbAnimacao.Size = new System.Drawing.Size(171, 20);
            this.txbAnimacao.TabIndex = 11;
            // 
            // txbClimatizado
            // 
            this.txbClimatizado.Location = new System.Drawing.Point(171, 145);
            this.txbClimatizado.Name = "txbClimatizado";
            this.txbClimatizado.Size = new System.Drawing.Size(171, 20);
            this.txbClimatizado.TabIndex = 12;
            // 
            // bntVendasIngressos
            // 
            this.bntVendasIngressos.Location = new System.Drawing.Point(100, 258);
            this.bntVendasIngressos.Name = "bntVendasIngressos";
            this.bntVendasIngressos.Size = new System.Drawing.Size(210, 23);
            this.bntVendasIngressos.TabIndex = 13;
            this.bntVendasIngressos.Text = "Vendas de Ingressos";
            this.bntVendasIngressos.UseVisualStyleBackColor = true;
            this.bntVendasIngressos.Click += new System.EventHandler(this.bntVendasIngressos_Click);
            // 
            // Cadastro_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
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
    }
}