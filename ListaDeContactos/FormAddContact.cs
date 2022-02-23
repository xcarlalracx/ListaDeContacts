using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeContactos
{
    public partial class FormAddContact : Form
    {
        public FormAddContact()
        {
            InitializeComponent();
        }

        private List<Contact> contacts = new List<Contact>();


        private void Inserir_Click(object sender, EventArgs e)
        {
            Form1.setName = textBoxNome.Text;
            Form1.setAddress = textBoxMorada.Text;
            Form1.setNumber = textBoxNumero.Text;
            this.Close();
        }
    }
}
