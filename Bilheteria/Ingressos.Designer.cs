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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txbHorário = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingressos";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.AutoSize = true;
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(64, 184);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(108, 24);
            this.txbQuantidade.TabIndex = 2;
            this.txbQuantidade.Text = "Quantidade";
            // 
            // txbFilme
            // 
            this.txbFilme.AutoSize = true;
            this.txbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilme.Location = new System.Drawing.Point(64, 98);
            this.txbFilme.Name = "txbFilme";
            this.txbFilme.Size = new System.Drawing.Size(57, 24);
            this.txbFilme.TabIndex = 3;
            this.txbFilme.Text = "Filme";
            // 
            // cbFilme
            // 
            this.cbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Location = new System.Drawing.Point(178, 101);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(130, 24);
            this.cbFilme.TabIndex = 4;
            this.cbFilme.Text = "Selecione";
            // 
            // txbSala
            // 
            this.txbSala.AutoSize = true;
            this.txbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSala.Location = new System.Drawing.Point(64, 142);
            this.txbSala.Name = "txbSala";
            this.txbSala.Size = new System.Drawing.Size(46, 24);
            this.txbSala.TabIndex = 7;
            this.txbSala.Text = "Sala";
            // 
            // cbSala
            // 
            this.cbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(178, 142);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(130, 24);
            this.cbSala.TabIndex = 8;
            this.cbSala.Text = "Selecione";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(178, 190);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // txbHorário
            // 
            this.txbHorário.AutoSize = true;
            this.txbHorário.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHorário.Location = new System.Drawing.Point(64, 229);
            this.txbHorário.Name = "txbHorário";
            this.txbHorário.Size = new System.Drawing.Size(72, 24);
            this.txbHorário.TabIndex = 10;
            this.txbHorário.Text = "Horário";
            // 
            // cbHorario
            // 
            this.cbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(178, 232);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(130, 24);
            this.cbHorario.TabIndex = 11;
            this.cbHorario.Text = "Selecione";
            // 
            // VendasIngressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 326);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.txbHorário);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.txbSala);
            this.Controls.Add(this.cbFilme);
            this.Controls.Add(this.txbFilme);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.label1);
            this.Name = "VendasIngressos";
            this.Text = "Ingressos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label txbHorário;
        private System.Windows.Forms.ComboBox cbHorario;
    }
}