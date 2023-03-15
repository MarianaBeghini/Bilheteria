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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txbQuantidade = new System.Windows.Forms.Label();
            this.txbFilme = new System.Windows.Forms.Label();
            this.cbFilme = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.AutoSize = true;
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(39, 102);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(108, 24);
            this.txbQuantidade.TabIndex = 2;
            this.txbQuantidade.Text = "Quantidade";
            // 
            // txbFilme
            // 
            this.txbFilme.AutoSize = true;
            this.txbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilme.Location = new System.Drawing.Point(48, 149);
            this.txbFilme.Name = "txbFilme";
            this.txbFilme.Size = new System.Drawing.Size(57, 24);
            this.txbFilme.TabIndex = 3;
            this.txbFilme.Text = "Filme";
            // 
            // cbFilme
            // 
            this.cbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Location = new System.Drawing.Point(156, 150);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(130, 26);
            this.cbFilme.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VendasIngressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbFilme);
            this.Controls.Add(this.txbFilme);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "VendasIngressos";
            this.Text = "Ingressos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txbQuantidade;
        private System.Windows.Forms.Label txbFilme;
        private System.Windows.Forms.ComboBox cbFilme;
        private System.Windows.Forms.Button button1;
    }
}