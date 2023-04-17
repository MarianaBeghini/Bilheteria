namespace Bilheteria
{
    partial class VendasIngressos
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
            this.txbQuantidade = new System.Windows.Forms.Label();
            this.txbFilme = new System.Windows.Forms.Label();
            this.cbFilme = new System.Windows.Forms.ComboBox();
            this.txbSala = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.numeQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txbHorário = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingressos";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.AutoSize = true;
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(44, 186);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(108, 24);
            this.txbQuantidade.TabIndex = 2;
            this.txbQuantidade.Text = "Quantidade";
            // 
            // txbFilme
            // 
            this.txbFilme.AutoSize = true;
            this.txbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilme.Location = new System.Drawing.Point(44, 98);
            this.txbFilme.Name = "txbFilme";
            this.txbFilme.Size = new System.Drawing.Size(57, 24);
            this.txbFilme.TabIndex = 3;
            this.txbFilme.Text = "Filme";
            // 
            // cbFilme
            // 
            this.cbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Location = new System.Drawing.Point(182, 101);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(130, 24);
            this.cbFilme.TabIndex = 4;
            this.cbFilme.Text = "Selecione";
            // 
            // txbSala
            // 
            this.txbSala.AutoSize = true;
            this.txbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSala.Location = new System.Drawing.Point(44, 142);
            this.txbSala.Name = "txbSala";
            this.txbSala.Size = new System.Drawing.Size(46, 24);
            this.txbSala.TabIndex = 7;
            this.txbSala.Text = "Sala";
            // 
            // cbSala
            // 
            this.cbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(182, 145);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(130, 24);
            this.cbSala.TabIndex = 8;
            this.cbSala.Text = "Selecione";
            // 
            // numeQuantidade
            // 
            this.numeQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeQuantidade.Location = new System.Drawing.Point(182, 190);
            this.numeQuantidade.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numeQuantidade.Name = "numeQuantidade";
            this.numeQuantidade.Size = new System.Drawing.Size(130, 22);
            this.numeQuantidade.TabIndex = 9;
            // 
            // txbHorário
            // 
            this.txbHorário.AutoSize = true;
            this.txbHorário.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHorário.Location = new System.Drawing.Point(44, 229);
            this.txbHorário.Name = "txbHorário";
            this.txbHorário.Size = new System.Drawing.Size(72, 24);
            this.txbHorário.TabIndex = 10;
            this.txbHorário.Text = "Horário";
            // 
            // cbHorario
            // 
            this.cbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(182, 232);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(130, 24);
            this.cbHorario.TabIndex = 11;
            this.cbHorario.Text = "Selecione";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(225, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Finalizar Compra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(48, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(48, 372);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(81, 32);
            this.voltar.TabIndex = 14;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // VendasIngressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 416);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.txbHorário);
            this.Controls.Add(this.numeQuantidade);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.txbSala);
            this.Controls.Add(this.cbFilme);
            this.Controls.Add(this.txbFilme);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.label1);
            this.Name = "VendasIngressos";
            this.Text = "Ingressos";
            ((System.ComponentModel.ISupportInitialize)(this.numeQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txbQuantidade;
        private System.Windows.Forms.Label txbFilme;
        private System.Windows.Forms.ComboBox cbFilme;
        private System.Windows.Forms.Label txbSala;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.NumericUpDown numeQuantidade;
        private System.Windows.Forms.Label txbHorário;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button voltar;
    }
}