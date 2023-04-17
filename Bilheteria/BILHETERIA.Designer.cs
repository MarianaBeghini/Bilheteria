namespace Bilheteria
{
    partial class BILHETERIA
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
            this.cadastrofilme = new System.Windows.Forms.Button();
            this.cadastrosala = new System.Windows.Forms.Button();
            this.cadastroingressos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILHETERIA";
            // 
            // cadastrofilme
            // 
            this.cadastrofilme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cadastrofilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrofilme.Location = new System.Drawing.Point(90, 117);
            this.cadastrofilme.Name = "cadastrofilme";
            this.cadastrofilme.Size = new System.Drawing.Size(207, 34);
            this.cadastrofilme.TabIndex = 1;
            this.cadastrofilme.Text = "Cadastro de Filme";
            this.cadastrofilme.UseVisualStyleBackColor = false;
            this.cadastrofilme.Click += new System.EventHandler(this.cadastrofilme_Click);
            // 
            // cadastrosala
            // 
            this.cadastrosala.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cadastrosala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosala.Location = new System.Drawing.Point(90, 186);
            this.cadastrosala.Name = "cadastrosala";
            this.cadastrosala.Size = new System.Drawing.Size(207, 32);
            this.cadastrosala.TabIndex = 2;
            this.cadastrosala.Text = "Cadastro de Sala";
            this.cadastrosala.UseVisualStyleBackColor = false;
            this.cadastrosala.Click += new System.EventHandler(this.cadastrosala_Click);
            // 
            // cadastroingressos
            // 
            this.cadastroingressos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cadastroingressos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroingressos.Location = new System.Drawing.Point(90, 253);
            this.cadastroingressos.Name = "cadastroingressos";
            this.cadastroingressos.Size = new System.Drawing.Size(207, 32);
            this.cadastroingressos.TabIndex = 3;
            this.cadastroingressos.Text = "Cadastro de Ingresso";
            this.cadastroingressos.UseVisualStyleBackColor = false;
            this.cadastroingressos.Click += new System.EventHandler(this.cadastroingressos_Click);
            // 
            // BILHETERIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.cadastroingressos);
            this.Controls.Add(this.cadastrosala);
            this.Controls.Add(this.cadastrofilme);
            this.Controls.Add(this.label1);
            this.Name = "BILHETERIA";
            this.Text = "BILHETERIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrofilme;
        private System.Windows.Forms.Button cadastrosala;
        private System.Windows.Forms.Button cadastroingressos;
    }
}