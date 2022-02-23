namespace ListaDeContactos
{
    partial class FormAddContact
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
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(12, 156);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(292, 27);
            this.textBoxNumero.TabIndex = 12;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(12, 96);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(292, 27);
            this.textBoxMorada.TabIndex = 11;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 34);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(292, 27);
            this.textBoxNome.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Insira o número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insira a morada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insira o nome";
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(210, 191);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(94, 29);
            this.Inserir.TabIndex = 13;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // formAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 232);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formAddContact";
            this.Text = "Adicionar Contacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNumero;
        private TextBox textBoxMorada;
        private TextBox textBoxNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Inserir;
    }
}