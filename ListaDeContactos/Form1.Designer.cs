namespace ListaDeContactos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.InserirNovoContacto = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 20;
            this.listBoxContacts.Location = new System.Drawing.Point(12, 47);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(297, 164);
            this.listBoxContacts.TabIndex = 7;
            this.listBoxContacts.SelectedIndexChanged += new System.EventHandler(this.listBoxContacts_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(215, 217);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(94, 29);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Location = new System.Drawing.Point(12, 12);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(94, 29);
            this.buttonAbrir.TabIndex = 11;
            this.buttonAbrir.Text = "Abrir   ";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // InserirNovoContacto
            // 
            this.InserirNovoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InserirNovoContacto.Location = new System.Drawing.Point(190, 12);
            this.InserirNovoContacto.Name = "InserirNovoContacto";
            this.InserirNovoContacto.Size = new System.Drawing.Size(119, 29);
            this.InserirNovoContacto.TabIndex = 14;
            this.InserirNovoContacto.Text = "Novo Contacto";
            this.InserirNovoContacto.UseVisualStyleBackColor = true;
            this.InserirNovoContacto.Click += new System.EventHandler(this.InserirNovoContacto_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(115, 217);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(94, 29);
            this.Editar.TabIndex = 15;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 262);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.InserirNovoContacto);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxContacts);
            this.Name = "Form1";
            this.Text = "Lista de Contactos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox listBoxContacts;
        private Button button1;
        private Button buttonGuardar;
        private Button buttonAbrir;
        private Button InserirNovoContacto;
        private Button Editar;
    }
}