namespace ListaDeContactos
{
    partial class FormEditContact
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
            this.Gravar = new System.Windows.Forms.Button();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gravar
            // 
            this.Gravar.Location = new System.Drawing.Point(210, 189);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(94, 29);
            this.Gravar.TabIndex = 20;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(12, 154);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(292, 27);
            this.textBoxNumero.TabIndex = 19;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(12, 94);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(292, 27);
            this.textBoxMorada.TabIndex = 18;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(292, 27);
            this.textBoxNome.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Insira o número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Insira a morada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Insira o nome";
            // 
            // FormEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 228);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditContact";
            this.Text = "FormEditContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Gravar;
        private TextBox textBoxNumero;
        private TextBox textBoxMorada;
        private TextBox textBoxNome;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}