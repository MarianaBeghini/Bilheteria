namespace Bilheteria
{
    partial class Tela_Principal
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
            this.txbBilheteria = new System.Windows.Forms.Label();
            this.bntCadastro_Filme = new System.Windows.Forms.Button();
            this.bntCadastro_Sala = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbBilheteria
            // 
            this.txbBilheteria.AutoSize = true;
            this.txbBilheteria.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBilheteria.Location = new System.Drawing.Point(40, 20);
            this.txbBilheteria.Name = "txbBilheteria";
            this.txbBilheteria.Size = new System.Drawing.Size(162, 39);
            this.txbBilheteria.TabIndex = 0;
            this.txbBilheteria.Text = "Bilheteria ";
            this.txbBilheteria.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntCadastro_Filme
            // 
            this.bntCadastro_Filme.Location = new System.Drawing.Point(47, 209);
            this.bntCadastro_Filme.Name = "bntCadastro_Filme";
            this.bntCadastro_Filme.Size = new System.Drawing.Size(131, 27);
            this.bntCadastro_Filme.TabIndex = 1;
            this.bntCadastro_Filme.Text = "Cadastro de Filmes";
            this.bntCadastro_Filme.UseVisualStyleBackColor = true;
            // 
            // bntCadastro_Sala
            // 
            this.bntCadastro_Sala.Location = new System.Drawing.Point(47, 264);
            this.bntCadastro_Sala.Name = "bntCadastro_Sala";
            this.bntCadastro_Sala.Size = new System.Drawing.Size(131, 27);
            this.bntCadastro_Sala.TabIndex = 2;
            this.bntCadastro_Sala.Text = "Cadastro de Salas";
            this.bntCadastro_Sala.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastro de Salas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ingressos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntCadastro_Sala);
            this.Controls.Add(this.bntCadastro_Filme);
            this.Controls.Add(this.txbBilheteria);
            this.Name = "Tela_Principal";
            this.Text = "Tela_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txbBilheteria;
        private System.Windows.Forms.Button bntCadastro_Filme;
        private System.Windows.Forms.Button bntCadastro_Sala;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}