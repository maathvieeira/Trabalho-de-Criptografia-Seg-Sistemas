namespace Cript
{
    partial class Form1
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
            this.btnCript = new System.Windows.Forms.Button();
            this.btnDescript = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCript
            // 
            this.btnCript.Location = new System.Drawing.Point(343, 183);
            this.btnCript.Name = "btnCript";
            this.btnCript.Size = new System.Drawing.Size(102, 41);
            this.btnCript.TabIndex = 0;
            this.btnCript.Text = "CRIPTOGRAFAR";
            this.btnCript.UseVisualStyleBackColor = true;
            this.btnCript.Click += new System.EventHandler(this.btnCript_Click);
            // 
            // btnDescript
            // 
            this.btnDescript.Location = new System.Drawing.Point(316, 409);
            this.btnDescript.Name = "btnDescript";
            this.btnDescript.Size = new System.Drawing.Size(129, 41);
            this.btnDescript.TabIndex = 1;
            this.btnDescript.Text = "DESCRIPTOGRAFAR";
            this.btnDescript.UseVisualStyleBackColor = true;
            this.btnDescript.Click += new System.EventHandler(this.btnDescript_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox1.Location = new System.Drawing.Point(34, 21);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(411, 156);
            this.txtBox1.TabIndex = 2;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(34, 243);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(411, 160);
            this.txtBox2.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(34, 409);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar Tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 472);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnDescript);
            this.Controls.Add(this.btnCript);
            this.Name = "Form1";
            this.Text = "Cript - Cifra de César";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCript;
        private System.Windows.Forms.Button btnDescript;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btnLimpar;
    }
}

