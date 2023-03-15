namespace Bilheteria
{
    partial class CadastroFilmes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFilme = new System.Windows.Forms.Label();
            this.txbNomeFilme = new System.Windows.Forms.TextBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.txbClassificacao = new System.Windows.Forms.TextBox();
            this.classificacao = new System.Windows.Forms.Label();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.catagoria = new System.Windows.Forms.Label();
            this.txbDuracao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbResenha = new System.Windows.Forms.TextBox();
            this.Resenha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textSala = new System.Windows.Forms.TextBox();
            this.Horário = new System.Windows.Forms.Label();
            this.txbHorario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomeFilme
            // 
            this.lblNomeFilme.AutoSize = true;
            this.lblNomeFilme.Location = new System.Drawing.Point(22, 29);
            this.lblNomeFilme.Name = "lblNomeFilme";
            this.lblNomeFilme.Size = new System.Drawing.Size(62, 13);
            this.lblNomeFilme.TabIndex = 0;
            this.lblNomeFilme.Text = "Nome Filme";
            // 
            // txbNomeFilme
            // 
            this.txbNomeFilme.Location = new System.Drawing.Point(109, 26);
            this.txbNomeFilme.Name = "txbNomeFilme";
            this.txbNomeFilme.Size = new System.Drawing.Size(126, 20);
            this.txbNomeFilme.TabIndex = 1;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(25, 320);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 2;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // txbClassificacao
            // 
            this.txbClassificacao.Location = new System.Drawing.Point(109, 66);
            this.txbClassificacao.Name = "txbClassificacao";
            this.txbClassificacao.Size = new System.Drawing.Size(126, 20);
            this.txbClassificacao.TabIndex = 3;
            // 
            // classificacao
            // 
            this.classificacao.AutoSize = true;
            this.classificacao.Location = new System.Drawing.Point(22, 73);
            this.classificacao.Name = "classificacao";
            this.classificacao.Size = new System.Drawing.Size(69, 13);
            this.classificacao.TabIndex = 4;
            this.classificacao.Text = "Classificação";
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(109, 101);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(126, 20);
            this.txbCategoria.TabIndex = 5;
            // 
            // catagoria
            // 
            this.catagoria.AutoSize = true;
            this.catagoria.Location = new System.Drawing.Point(22, 108);
            this.catagoria.Name = "catagoria";
            this.catagoria.Size = new System.Drawing.Size(52, 13);
            this.catagoria.TabIndex = 6;
            this.catagoria.Text = "Categoria";
            // 
            // txbDuracao
            // 
            this.txbDuracao.Location = new System.Drawing.Point(109, 139);
            this.txbDuracao.Name = "txbDuracao";
            this.txbDuracao.Size = new System.Drawing.Size(126, 20);
            this.txbDuracao.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Duração";
            // 
            // txbResenha
            // 
            this.txbResenha.Location = new System.Drawing.Point(109, 176);
            this.txbResenha.Name = "txbResenha";
            this.txbResenha.Size = new System.Drawing.Size(126, 20);
            this.txbResenha.TabIndex = 9;
            // 
            // Resenha
            // 
            this.Resenha.AutoSize = true;
            this.Resenha.Location = new System.Drawing.Point(22, 179);
            this.Resenha.Name = "Resenha";
            this.Resenha.Size = new System.Drawing.Size(50, 13);
            this.Resenha.TabIndex = 10;
            this.Resenha.Text = "Resenha";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(177, 320);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(232, 390);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar Sala";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sala";
            // 
            // textSala
            // 
            this.textSala.Location = new System.Drawing.Point(109, 216);
            this.textSala.Name = "textSala";
            this.textSala.Size = new System.Drawing.Size(126, 20);
            this.textSala.TabIndex = 14;
            // 
            // Horário
            // 
            this.Horário.AutoSize = true;
            this.Horário.Location = new System.Drawing.Point(22, 256);
            this.Horário.Name = "Horário";
            this.Horário.Size = new System.Drawing.Size(41, 13);
            this.Horário.TabIndex = 15;
            this.Horário.Text = "Horário";
            // 
            // txbHorario
            // 
            this.txbHorario.Location = new System.Drawing.Point(109, 256);
            this.txbHorario.Name = "txbHorario";
            this.txbHorario.Size = new System.Drawing.Size(126, 20);
            this.txbHorario.TabIndex = 16;
            this.txbHorario.TextChanged += new System.EventHandler(this.textHorario_TextChanged);
            // 
            // CadastroFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 425);
            this.Controls.Add(this.txbHorario);
            this.Controls.Add(this.Horário);
            this.Controls.Add(this.textSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.Resenha);
            this.Controls.Add(this.txbResenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDuracao);
            this.Controls.Add(this.catagoria);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.classificacao);
            this.Controls.Add(this.txbClassificacao);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txbNomeFilme);
            this.Controls.Add(this.lblNomeFilme);
            this.Name = "CadastroFilmes";
            this.Text = "Cadastro Filmes";
            this.Load += new System.EventHandler(this.CadastroFilmes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFilme;
        private System.Windows.Forms.TextBox txbNomeFilme;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.TextBox txbClassificacao;
        private System.Windows.Forms.Label classificacao;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.Label catagoria;
        private System.Windows.Forms.TextBox txbDuracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbResenha;
        private System.Windows.Forms.Label Resenha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSala;
        private System.Windows.Forms.Label Horário;
        private System.Windows.Forms.TextBox txbHorario;
    }
}

